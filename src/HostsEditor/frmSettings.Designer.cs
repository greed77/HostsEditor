namespace HostsEditor
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkFlushDNS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCheckForUpdates
            // 
            this.chkCheckForUpdates.AutoSize = true;
            this.chkCheckForUpdates.Location = new System.Drawing.Point(12, 12);
            this.chkCheckForUpdates.Name = "chkCheckForUpdates";
            this.chkCheckForUpdates.Size = new System.Drawing.Size(163, 17);
            this.chkCheckForUpdates.TabIndex = 0;
            this.chkCheckForUpdates.Text = "Check for updates on startup";
            this.chkCheckForUpdates.UseVisualStyleBackColor = true;
            this.chkCheckForUpdates.CheckedChanged += new System.EventHandler(this.chkCheckForUpdates_CheckedChanged);
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(12, 35);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(142, 17);
            this.chkAutoBackup.TabIndex = 1;
            this.chkAutoBackup.Text = "Make backup on launch";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            this.chkAutoBackup.CheckedChanged += new System.EventHandler(this.chkAutoBackup_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkFlushDNS
            // 
            this.chkFlushDNS.AutoSize = true;
            this.chkFlushDNS.Location = new System.Drawing.Point(12, 58);
            this.chkFlushDNS.Name = "chkFlushDNS";
            this.chkFlushDNS.Size = new System.Drawing.Size(118, 17);
            this.chkFlushDNS.TabIndex = 3;
            this.chkFlushDNS.Text = "Flush DNS on save";
            this.chkFlushDNS.UseVisualStyleBackColor = true;
            this.chkFlushDNS.CheckedChanged += new System.EventHandler(this.chkFlushDNS_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 251);
            this.Controls.Add(this.chkFlushDNS);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkAutoBackup);
            this.Controls.Add(this.chkCheckForUpdates);
            this.Name = "frmSettings";
            this.Text = "Application Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCheckForUpdates;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkFlushDNS;
    }
}