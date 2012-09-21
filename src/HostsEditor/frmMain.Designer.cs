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
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvHosts = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAddHost = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvHostsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvHostsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHostsDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlAddHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDomain.Location = new System.Drawing.Point(153, 5);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(135, 20);
            this.txtDomain.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.Location = new System.Drawing.Point(4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save host";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvHosts
            // 
            this.dgvHosts.AllowUserToAddRows = false;
            this.dgvHosts.AllowUserToResizeColumns = false;
            this.dgvHosts.AllowUserToResizeRows = false;
            this.dgvHosts.BackgroundColor = System.Drawing.Color.White;
            this.dgvHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHostsActive,
            this.dgvHostsAddress,
            this.dgvHostsDomain});
            this.dgvHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHosts.Location = new System.Drawing.Point(0, 24);
            this.dgvHosts.MultiSelect = false;
            this.dgvHosts.Name = "dgvHosts";
            this.dgvHosts.Size = new System.Drawing.Size(484, 158);
            this.dgvHosts.TabIndex = 11;
            this.dgvHosts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHosts_CellValueChanged);
            this.dgvHosts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHosts_RowsRemoved);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlAddHost);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 182);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(484, 30);
            this.pnlBottom.TabIndex = 12;
            // 
            // pnlAddHost
            // 
            this.pnlAddHost.Controls.Add(this.btnAddCancel);
            this.pnlAddHost.Controls.Add(this.btnSave);
            this.pnlAddHost.Controls.Add(this.txtDomain);
            this.pnlAddHost.Controls.Add(this.txtAddress);
            this.pnlAddHost.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHost.Name = "pnlAddHost";
            this.pnlAddHost.Size = new System.Drawing.Size(459, 30);
            this.pnlAddHost.TabIndex = 13;
            this.pnlAddHost.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(376, 3);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 24);
            this.btnAddCancel.TabIndex = 4;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAdd.Location = new System.Drawing.Point(2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add host";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvHostsActive
            // 
            this.dgvHostsActive.HeaderText = "Active";
            this.dgvHostsActive.Name = "dgvHostsActive";
            this.dgvHostsActive.Width = 42;
            // 
            // dgvHostsAddress
            // 
            this.dgvHostsAddress.HeaderText = "IP Address";
            this.dgvHostsAddress.Name = "dgvHostsAddress";
            // 
            // dgvHostsDomain
            // 
            this.dgvHostsDomain.HeaderText = "Domain";
            this.dgvHostsDomain.Name = "dgvHostsDomain";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.dgvHosts);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "frmMain";
            this.Text = "Hosts File Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlAddHost.ResumeLayout(false);
            this.pnlAddHost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvHosts;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlAddHost;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvHostsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHostsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHostsDomain;
    }
}

