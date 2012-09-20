using System;
using System.Windows.Forms;
using System.IO;

namespace HostsEditor
{
    public partial class frmMain : Form
    {
        private const string FILE_NAME = "C:\\Windows\\System32\\drivers\\etc\\hosts";

        public frmMain()
        {
            InitializeComponent();
            ArrangeForm();
            ReadHosts();
        }

        public void ArrangeForm()
        {
            this.lstHosts.Location = new System.Drawing.Point(5, 5);
            this.lstHosts.Size = new System.Drawing.Size((this.Width - 25), (this.Height - 150));

            this.lstHosts.Columns[0].Width = 20;
            this.lstHosts.Columns[1].Width = ((this.lstHosts.Width - this.lstHosts.Columns[0].Width) / 2) - 2;
            this.lstHosts.Columns[2].Width = ((this.lstHosts.Width - this.lstHosts.Columns[0].Width) / 2) - 2;

            this.lblAddress.Location = new System.Drawing.Point(5, (this.Height - 125));
            this.txtAddress.Location = new System.Drawing.Point(5, (this.Height - 100));

            this.lblDomain.Location = new System.Drawing.Point(150, (this.Height - 125));
            this.txtDomain.Location = new System.Drawing.Point(150, (this.Height - 100));

            this.btnSave.Location = new System.Drawing.Point(300, (this.Height - 102));
        }

        public void ReadHosts()
        {
            lstHosts.Items.Clear();

            if (!File.Exists(FILE_NAME))
            {
                MessageBox.Show(FILE_NAME + " does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader sr = File.OpenText(FILE_NAME))
                {
                    String input;

                    while ((input = sr.ReadLine()) != null)
                    {
                        bool bDisabled = input.StartsWith("#");

                        input = input.Replace("#", "").Trim();
                        string[] line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length == 2)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems.Add(line[0]);
                            item.SubItems.Add(line[1]);
                            if (bDisabled)
                            {
                                item.Checked = false;
                            }
                            else
                            {
                                item.Checked = true;
                            }
                            lstHosts.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read\n" + e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void WriteHosts()
        {
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            ArrangeForm();
        }

        private void lstHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstHosts.SelectedItems.Count > 0)
            {
                this.txtAddress.Text = this.lstHosts.SelectedItems[0].SubItems[1].Text;
                this.txtDomain.Text = this.lstHosts.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
