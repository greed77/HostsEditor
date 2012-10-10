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
            this.lblCurrentBackups = new System.Windows.Forms.Label();
            this.btnBackupsRestore = new System.Windows.Forms.Button();
            this.btnBackupsDelete = new System.Windows.Forms.Button();
            this.btnBackupsCancel = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lstBackups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCurrentBackups
            // 
            this.lblCurrentBackups.AutoSize = true;
            this.lblCurrentBackups.Location = new System.Drawing.Point(9, 9);
            this.lblCurrentBackups.Name = "lblCurrentBackups";
            this.lblCurrentBackups.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentBackups.TabIndex = 1;
            this.lblCurrentBackups.Text = "Current Backups:";
            // 
            // btnBackupsRestore
            // 
            this.btnBackupsRestore.Location = new System.Drawing.Point(101, 321);
            this.btnBackupsRestore.Name = "btnBackupsRestore";
            this.btnBackupsRestore.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsRestore.TabIndex = 2;
            this.btnBackupsRestore.Text = "Restore";
            this.btnBackupsRestore.UseVisualStyleBackColor = true;
            this.btnBackupsRestore.Visible = false;
            this.btnBackupsRestore.Click += new System.EventHandler(this.btnBackupsRestore_Click);
            // 
            // btnBackupsDelete
            // 
            this.btnBackupsDelete.Location = new System.Drawing.Point(12, 321);
            this.btnBackupsDelete.Name = "btnBackupsDelete";
            this.btnBackupsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsDelete.TabIndex = 3;
            this.btnBackupsDelete.Text = "Delete";
            this.btnBackupsDelete.UseVisualStyleBackColor = true;
            this.btnBackupsDelete.Visible = false;
            this.btnBackupsDelete.Click += new System.EventHandler(this.btnBackupsDelete_Click);
            // 
            // btnBackupsCancel
            // 
            this.btnBackupsCancel.Location = new System.Drawing.Point(353, 321);
            this.btnBackupsCancel.Name = "btnBackupsCancel";
            this.btnBackupsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBackupsCancel.TabIndex = 4;
            this.btnBackupsCancel.Text = "Cancel";
            this.btnBackupsCancel.UseVisualStyleBackColor = true;
            this.btnBackupsCancel.Click += new System.EventHandler(this.btnBackupsCancel_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Enabled = false;
            this.txtPreview.Location = new System.Drawing.Point(204, 32);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(224, 277);
            this.txtPreview.TabIndex = 5;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(201, 9);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(48, 13);
            this.lblPreview.TabIndex = 6;
            this.lblPreview.Text = "Preview:";
            // 
            // lstBackups
            // 
            this.lstBackups.FormattingEnabled = true;
            this.lstBackups.Location = new System.Drawing.Point(12, 32);
            this.lstBackups.Name = "lstBackups";
            this.lstBackups.Size = new System.Drawing.Size(186, 277);
            this.lstBackups.TabIndex = 7;
            this.lstBackups.SelectedIndexChanged += new System.EventHandler(this.lstBackups_SelectedIndexChanged);
            // 
            // frmBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.lstBackups);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnBackupsCancel);
            this.Controls.Add(this.btnBackupsDelete);
            this.Controls.Add(this.btnBackupsRestore);
            this.Controls.Add(this.lblCurrentBackups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackups";
            this.Text = "Manage Backups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentBackups;
        private System.Windows.Forms.Button btnBackupsRestore;
        private System.Windows.Forms.Button btnBackupsDelete;
        private System.Windows.Forms.Button btnBackupsCancel;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ListBox lstBackups;
    }
}