using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using AutoUpdaterDotNET;

namespace HostsEditor
{
    public partial class frmMain : Form
    {
        public bool has_loaded_data = false;
        public string host_file = Path.Combine(Environment.SystemDirectory, "drivers\\etc\\hosts");
        public string backup_dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HostFileBackups");
        public string backup_filename = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".hosts";

        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache();

        public frmMain()
        {
            this.Icon = Properties.Resources.edit_ico;
            InitializeComponent();
            ReadHosts(host_file);
            if (!Directory.Exists(backup_dir))
            {
                Directory.CreateDirectory(backup_dir);
            }

            if (Properties.Settings.Default.BackupOnLaunch)
            {
                WriteHosts(Path.Combine(backup_dir, backup_filename));
            }
        }

        public frmMain(bool make_backup)
        {
            this.Icon = Properties.Resources.edit_ico;
            InitializeComponent();
            ReadHosts(host_file);
            if (!Directory.Exists(backup_dir))
            {
                Directory.CreateDirectory(backup_dir);
            }

            if (make_backup)
            {
                WriteHosts(Path.Combine(backup_dir, backup_filename));
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.pnlAddHost.Show();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            this.pnlAddHost.Hide();
        }

        public void ReadHosts(string file_name)
        {
            if (!File.Exists(file_name))
            {
                MessageBox.Show(file_name + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            has_loaded_data = false;
            try
            {
                using (StreamReader sr = File.OpenText(file_name))
                {
                    String input;

                    this.dgvHosts.Rows.Clear();
                    this.txtAdvanced.Text = "";

                    while ((input = sr.ReadLine()) != null)
                    {
                        bool bDisabled = input.StartsWith("#");

                        this.txtAdvanced.Text += input + Environment.NewLine;

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
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            has_loaded_data = true;
        }

        public void WriteHosts(string file_name)
        {
            if (has_loaded_data)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(file_name))
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be written\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHosts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (has_loaded_data)
            {
                WriteHosts(host_file);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtAddress.Text.Trim() == "" || this.txtAddress.Text.Trim() == "IP Address" || this.txtDomain.Text.Trim() == "" || this.txtDomain.Text.Trim() == "Domain")
            {
                MessageBox.Show("You need to specify both an address and a domain.");
            }
            else
            {
                has_loaded_data = false;
                int n = this.dgvHosts.Rows.Add();
                this.dgvHosts.Rows[n].Cells[0].Value = true;
                this.dgvHosts.Rows[n].Cells[1].Value = this.txtAddress.Text;
                this.dgvHosts.Rows[n].Cells[2].Value = this.txtDomain.Text;
                has_loaded_data = true;

                this.txtAddress.Text = "";
                this.txtDomain.Text = "";

                WriteHosts(host_file);

                if (Properties.Settings.Default.FlushDNSOnSave)
                {
                    FlushMyCache();
                }
            }
        }

        private void dgvHosts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            WriteHosts(host_file);
        }

        private void btnAdvancedSave_Click(object sender, EventArgs e)
        {
            if (has_loaded_data)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(host_file))
                    {
                        foreach (string line in this.txtAdvanced.Lines)
                        {
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Windows hosts file successfully written.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be written\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadHosts(host_file);
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.Show();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileImport_Click(object sender, EventArgs e)
        {
            DialogResult result = this.dlgOpen.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dlgOpen.FileName;
                try
                {
                    ReadHosts(file);
                    WriteHosts(host_file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("The file could not be read\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuFileExport_Click(object sender, EventArgs e)
        {
            DialogResult result = this.dlgExport.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dlgExport.FileName;
                try
                {
                    WriteHosts(file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("There was an error exporting the file.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            // this.txtAddress.Text = "";
            if (this.txtAddress.Text.Trim() == "IP Address")
            {
                this.txtAddress.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (this.txtAddress.Text.Trim() == "")
            {
                this.txtAddress.Text = "IP Address";
            }
        }

        private void txtDomain_Click(object sender, EventArgs e)
        {
            // this.txtDomain.Text = "";
            if (this.txtDomain.Text.Trim() == "Domain")
            {
                this.txtDomain.Text = "";
            }
        }

        private void txtDomain_Leave(object sender, EventArgs e)
        {
            if (this.txtDomain.Text.Trim() == "")
            {
                this.txtDomain.Text = "Domain";
            }
        }

        private void mnuFileBackups_Click(object sender, EventArgs e)
        {
            frmBackups form = new frmBackups(this);
            form.Show();
        }

        private void mnuFilePreferences_Click(object sender, EventArgs e)
        {
            frmSettings form = new frmSettings();
            form.Show();
        }

        public static void FlushMyCache()
        {
            UInt32 result = DnsFlushResolverCache();
        }

        private void mnuAboutUpdate_Click(object sender, EventArgs e)
        {
            AutoUpdater.ReportErrors = true;
            string url = "https://rbsoft.org/updates/AutoUpdaterTest.xml";
            //string url = "https://raw.githubusercontent.com/greed77/HostsEditor/master/AutoUpdater.xml";
            //MessageBox.Show(url);
            AutoUpdater.Start(url);
        }
    }
}
