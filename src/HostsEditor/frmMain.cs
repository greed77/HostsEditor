using System;
using System.Windows.Forms;
using System.IO;

namespace HostsEditor
{
    public partial class frmMain : Form
    {
        private const string FILE_NAME = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        public bool has_loaded_data = false;

        public frmMain()
        {
            this.Icon = Properties.Resources.edit_ico;
            InitializeComponent();
            ReadHosts();
            has_loaded_data = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.pnlAddHost.Show();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            this.pnlAddHost.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.Show();
        }

        public void ReadHosts()
        {
            //lstHosts.Items.Clear();

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
                            int n = this.dgvHosts.Rows.Add();

                            if (bDisabled)
                            {
                                this.dgvHosts.Rows[n].Cells[0].Value = false;
                            }
                            else
                            {
                                this.dgvHosts.Rows[n].Cells[0].Value = true;
                            }
                                                        
                            this.dgvHosts.Rows[n].Cells[1].Value = line[0];
                            this.dgvHosts.Rows[n].Cells[2].Value = line[1];
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
            if (has_loaded_data)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(FILE_NAME))
                    {
                        foreach (DataGridViewRow item in this.dgvHosts.Rows)
                        {
                            String newline = item.Cells[1].Value + "     " + item.Cells[2].Value;

                            if (Convert.ToBoolean(item.Cells[0].Value) == false)
                            {
                                newline = "# " + newline;
                            }
                            writer.WriteLine(newline);
                        }
                    }
                    //MessageBox.Show("Windows hosts file successfully written.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("The file could not be written\n" + e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvHosts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            WriteHosts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text.Trim() == "" || this.txtDomain.Text.Trim() == "")
            {
                MessageBox.Show("You need to specify both an address and a domain.");
            }
            else
            {
                int n = this.dgvHosts.Rows.Add();
                has_loaded_data = false;

                this.dgvHosts.Rows[n].Cells[0].Value = true;
                this.dgvHosts.Rows[n].Cells[1].Value = this.txtAddress.Text;
                this.dgvHosts.Rows[n].Cells[2].Value = this.txtDomain.Text;
                has_loaded_data = true;
                WriteHosts();
            }
        }

        private void dgvHosts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            WriteHosts();
        }
    }
}
