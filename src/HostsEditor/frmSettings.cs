using System;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            chkAutoBackup.Checked = Properties.Settings.Default.BackupOnLaunch;
            chkCheckForUpdates.Checked = Properties.Settings.Default.CheckForUpdates;
            chkFlushDNS.Checked = Properties.Settings.Default.FlushDNSOnSave;
        }

        private void chkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupOnLaunch = chkAutoBackup.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckForUpdates = chkCheckForUpdates.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkFlushDNS_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FlushDNSOnSave = chkFlushDNS.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
