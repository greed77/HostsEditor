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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
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
            this.lstHosts.Size = new System.Drawing.Size(469, 160);
            this.lstHosts.TabIndex = 0;
            this.lstHosts.UseCompatibleStateImageBehavior = false;
            this.lstHosts.View = System.Windows.Forms.View.Details;
            this.lstHosts.SelectedIndexChanged += new System.EventHandler(this.lstHosts_SelectedIndexChanged);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(222, 208);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(135, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 208);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(73, 189);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "IP Address";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(219, 189);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(43, 13);
            this.lblDomain.TabIndex = 6;
            this.lblDomain.Text = "Domain";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 288);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstHosts);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "frmMain";
            this.Text = "Hosts File Editor";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHosts;
        private System.Windows.Forms.ColumnHeader lstHostsEnabled;
        private System.Windows.Forms.ColumnHeader lstHostsAddress;
        private System.Windows.Forms.ColumnHeader lstHostsDomain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDomain;
    }
}

