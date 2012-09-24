using System;
using System.Windows.Forms;
using System.IO;

namespace HostsEditor
{
    public partial class frmBackups : Form
    {
        public string backup_dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HostFileBackups");

        public frmBackups()
        {
            InitializeComponent();
            LoadBackups();
        }

        private void btnBackupsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackupsDelete_Click(object sender, EventArgs e)
        {
            string backup_file = Path.Combine( backup_dir, this.drpBackups.SelectedItem.ToString());
            if (MessageBox.Show("Are you sure you want to delete this backup?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete(backup_file);
            }
            LoadBackups();
        }

        private void btnBackupsRestore_Click(object sender, EventArgs e)
        {
            string backup_file = Path.Combine(backup_dir, this.drpBackups.SelectedItem.ToString());
            if (MessageBox.Show("Are you sure you want to restore this backup?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //host_file = backup_file;
                frmMain form = new frmMain();
                form.ReadHosts(backup_file);
                this.Close();
                //MessageBox.Show(backup_file);
            }
        }

        public void LoadBackups()
        {
            string parsed_filename = "";

            this.drpBackups.Items.Clear();

            //this.drpBackups.DataSource = Directory.GetFiles(backup_dir);
            foreach (string backup in Directory.GetFiles(backup_dir))
            {
                parsed_filename = Path.GetFileName(backup);
                this.drpBackups.Items.Add(parsed_filename);
            }

            this.drpBackups.SelectedIndex = -1;
            this.drpBackups.Text = "";
        }
    }
}
