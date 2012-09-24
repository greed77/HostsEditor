namespace HostsEditor
{
    partial class frmBackups
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
            this.drpBackups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackupsRestore = new System.Windows.Forms.Button();
            this.btnBackupsDelete = new System.Windows.Forms.Button();
            this.btnBackupsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drpBackups
            // 
            this.drpBackups.FormattingEnabled = true;
            this.drpBackups.Location = new System.Drawing.Point(15, 32);
            this.drpBackups.Name = "drpBackups";
            this.drpBackups.Size = new System.Drawing.Size(250, 21);
            this.drpBackups.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Backups:";
            // 
            // btnBackupsRestore
            // 
            this.btnBackupsRestore.Location = new System.Drawing.Point(101, 68);
            this.btnBackupsRestore.Name = "btnBackupsRestore";
            this.btnBackupsRestore.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsRestore.TabIndex = 2;
            this.btnBackupsRestore.Text = "Restore";
            this.btnBackupsRestore.UseVisualStyleBackColor = true;
            this.btnBackupsRestore.Click += new System.EventHandler(this.btnBackupsRestore_Click);
            // 
            // btnBackupsDelete
            // 
            this.btnBackupsDelete.Location = new System.Drawing.Point(12, 68);
            this.btnBackupsDelete.Name = "btnBackupsDelete";
            this.btnBackupsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsDelete.TabIndex = 3;
            this.btnBackupsDelete.Text = "Delete";
            this.btnBackupsDelete.UseVisualStyleBackColor = true;
            this.btnBackupsDelete.Click += new System.EventHandler(this.btnBackupsDelete_Click);
            // 
            // btnBackupsCancel
            // 
            this.btnBackupsCancel.Location = new System.Drawing.Point(190, 68);
            this.btnBackupsCancel.Name = "btnBackupsCancel";
            this.btnBackupsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsCancel.TabIndex = 4;
            this.btnBackupsCancel.Text = "Cancel";
            this.btnBackupsCancel.UseVisualStyleBackColor = true;
            this.btnBackupsCancel.Click += new System.EventHandler(this.btnBackupsCancel_Click);
            // 
            // frmBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 104);
            this.Controls.Add(this.btnBackupsCancel);
            this.Controls.Add(this.btnBackupsDelete);
            this.Controls.Add(this.btnBackupsRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpBackups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackups";
            this.Text = "Manage Backups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drpBackups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackupsRestore;
        private System.Windows.Forms.Button btnBackupsDelete;
        private System.Windows.Forms.Button btnBackupsCancel;
    }
}