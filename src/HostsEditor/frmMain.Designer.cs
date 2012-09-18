namespace HostsEditor
{
    partial class frmMain
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
            this.lstHosts = new System.Windows.Forms.ListView();
            this.lstHostsEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHostsAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHostsDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstHosts
            // 
            this.lstHosts.CheckBoxes = true;
            this.lstHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstHostsEnabled,
            this.lstHostsAddress,
            this.lstHostsDomain});
            this.lstHosts.FullRowSelect = true;
            this.lstHosts.Location = new System.Drawing.Point(12, 12);
            this.lstHosts.MultiSelect = false;
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.Size = new System.Drawing.Size(469, 218);
            this.lstHosts.TabIndex = 0;
            this.lstHosts.UseCompatibleStateImageBehavior = false;
            this.lstHosts.View = System.Windows.Forms.View.Details;
            // 
            // lstHostsEnabled
            // 
            this.lstHostsEnabled.Text = "";
            // 
            // lstHostsAddress
            // 
            this.lstHostsAddress.Text = "IP Address";
            // 
            // lstHostsDomain
            // 
            this.lstHostsDomain.Text = "Domain";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 428);
            this.Controls.Add(this.lstHosts);
            this.Name = "frmMain";
            this.Text = "Hosts File Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstHosts;
        private System.Windows.Forms.ColumnHeader lstHostsEnabled;
        private System.Windows.Forms.ColumnHeader lstHostsAddress;
        private System.Windows.Forms.ColumnHeader lstHostsDomain;
    }
}

