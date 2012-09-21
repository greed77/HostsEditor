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
            this.Icon = Properties.Resources.edit_ico;
            InitializeComponent();
            ArrangeForm();
            ReadHosts();
        }

        public void ArrangeForm()
        {
            this.lstHosts.Location = new System.Drawing.Point(5, 25);
            this.lstHosts.Size = new System.Drawing.Size((this.Width - 25), (this.Height - 150));

            this.lstHosts.Columns[0].Width = 20;
            this.lstHosts.Columns[1].Width = ((this.lstHosts.Width - this.lstHosts.Columns[0].Width) / 2) - 2;
            this.lstHosts.Columns[2].Width = ((this.lstHosts.Width - this.lstHosts.Columns[0].Width) / 2) - 2;

            this.lblAddress.Location = new System.Drawing.Point(5, (this.Height - 118));
            this.txtAddress.Location = new System.Drawing.Point(5, (this.Height - 100));

            this.lblDomain.Location = new System.Drawing.Point(150, (this.Height - 118));
            this.txtDomain.Location = new System.Drawing.Point(150, (this.Height - 100));

            this.btnSave.Location = new System.Drawing.Point(210, (this.Height - 70));

            this.btnReset.Location = new System.Drawing.Point((this.Width - 95), (this.Height - 102));
            this.btnWrite.Location = new System.Drawing.Point((this.Width - 95), (this.Height - 70));

            if (this.lstHosts.SelectedItems.Count > 0)
            {
                this.btnSave.Text = "Save host";
            }
            else
            {
                this.btnSave.Text = "Add host";
            }

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
            try
            {
                using (StreamWriter writer = new StreamWriter(FILE_NAME))
                {
                    foreach (ListViewItem item in this.lstHosts.Items)
                    {
                        String newline = item.SubItems[1].Text + "     " + item.SubItems[2].Text;

                        if (item.Checked == false)
                        {
                            newline = "# " + newline;
                        }
                        writer.WriteLine(newline);
                    }
                }
                MessageBox.Show("Windows hosts file successfully written.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read\n" + e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                this.btnSave.Text = "Save host";
            }
            else
            {
                this.txtAddress.Text = "";
                this.txtDomain.Text = "";
                this.btnSave.Text = "Add host";
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lstHosts.SelectedIndices[0];
            if (index != -1)
            {
                this.lstHosts.Items[index].Remove();
            }
        }

        private void mnuHosts_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lstHosts.SelectedIndices.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            //MessageBox.Show("todo: show about form");
            form.Show();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?\n\nThis Action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                WriteHosts();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReadHosts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // add new host
            if (this.txtAddress.Text.Trim() == "" || this.txtDomain.Text.Trim() == "")
            {
                MessageBox.Show("You need to specify both an address and a domain.");
            }
            else
            {
                if (this.lstHosts.SelectedIndices.Count > 0)
                {
                    // update host
                    int index = this.lstHosts.SelectedIndices[0];
                    //MessageBox.Show(this.lstHosts.SelectedIndices[0].ToString());
                    this.lstHosts.Items[index].SubItems[1].Text = this.txtAddress.Text;
                    this.lstHosts.Items[index].SubItems[2].Text = this.txtDomain.Text;
                    this.lstHosts.SelectedItems.Clear();
                }
                else
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(this.txtAddress.Text);
                    item.SubItems.Add(this.txtDomain.Text);
                    item.Checked = true;
                    lstHosts.Items.Add(item);
                    this.txtAddress.Text = "";
                    this.txtDomain.Text = "";
                }
            }
        }
    }
}
