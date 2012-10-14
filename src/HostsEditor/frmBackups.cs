using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HostsEditor
{
    public partial class frmBackups : Form
    {
        frmMain frmMain;
        public string backup_dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HostFileBackups");

        public frmBackups()
        {
            InitializeComponent();
            LoadBackups();
        }

        public frmBackups(frmMain frm1)
        {
            InitializeComponent();
            frmMain = new frmMain(false);
            frmMain = frm1;
            LoadBackups();
        }

        private void btnBackupsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackupsDelete_Click(object sender, EventArgs e)
        {
            string backup_file = Path.Combine( backup_dir, this.lstBackups.SelectedItem.ToString());
            if (MessageBox.Show("Are you sure you want to delete this backup?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete(backup_file);
                this.txtPreview.Text = "";
            }
            LoadBackups();
        }

        private void btnBackupsRestore_Click(object sender, EventArgs e)
        {
            string backup_file = Path.Combine(backup_dir, this.lstBackups.SelectedItem.ToString());
            if (MessageBox.Show("Are you sure you want to restore this backup?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                frmMain.ReadHosts(backup_file);
                frmMain.WriteHosts(frmMain.host_file);
                this.Close();
            }
        }

        private void lstBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnBackupsDelete.Visible = true;
            this.btnBackupsRestore.Visible = true;
            if (this.lstBackups.SelectedItems.Count>0)
            {
                PreviewBackup(this.lstBackups.SelectedItem.ToString());
            }
        }

        private void lstBackups_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Debug.WriteLine(e.KeyChar);
        }

        public void LoadBackups()
        {
            string parsed_filename = "";
            this.lstBackups.Items.Clear();

            foreach (string backup in Directory.GetFiles(backup_dir))
            {
                parsed_filename = Path.GetFileName(backup);
                this.lstBackups.Items.Add(parsed_filename);
            }
            this.btnBackupsDelete.Visible = false;
            this.btnBackupsRestore.Visible = false;
        }

        public void PreviewBackup(string file_name)
        {
            file_name = Path.Combine(backup_dir, file_name);
            if (!File.Exists(file_name))
            {
                MessageBox.Show(file_name + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader sr = File.OpenText(file_name))
                {
                    String input;

                    this.txtPreview.Text = "";

                    while ((input = sr.ReadLine()) != null)
                    {
                        this.txtPreview.Text += input + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
