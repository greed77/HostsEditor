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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileBackups = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvHosts = new System.Windows.Forms.DataGridView();
            this.dgvHostsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvHostsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHostsDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAddHost = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.txtAdvanced = new System.Windows.Forms.TextBox();
            this.pnlAdvancedBottom = new System.Windows.Forms.Panel();
            this.btnAdvancedSave = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgExport = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlAddHost.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.pnlAdvancedBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDomain.Location = new System.Drawing.Point(153, 5);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(135, 20);
            this.txtDomain.TabIndex = 1;
            this.txtDomain.Text = "Domain";
            this.txtDomain.Click += new System.EventHandler(this.txtDomain_Click);
            this.txtDomain.Leave += new System.EventHandler(this.txtDomain_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.Location = new System.Drawing.Point(4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "IP Address";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileImport,
            this.mnuFileExport,
            this.mnuFileBackups,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuFileImport
            // 
            this.mnuFileImport.Name = "mnuFileImport";
            this.mnuFileImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuFileImport.Size = new System.Drawing.Size(205, 22);
            this.mnuFileImport.Text = "&Import file...";
            this.mnuFileImport.Click += new System.EventHandler(this.mnuFileImport_Click);
            // 
            // mnuFileExport
            // 
            this.mnuFileExport.Name = "mnuFileExport";
            this.mnuFileExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuFileExport.Size = new System.Drawing.Size(205, 22);
            this.mnuFileExport.Text = "&Export file...";
            this.mnuFileExport.Click += new System.EventHandler(this.mnuFileExport_Click);
            // 
            // mnuFileBackups
            // 
            this.mnuFileBackups.Name = "mnuFileBackups";
            this.mnuFileBackups.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuFileBackups.Size = new System.Drawing.Size(205, 22);
            this.mnuFileBackups.Text = "Manage &Backups";
            this.mnuFileBackups.Click += new System.EventHandler(this.mnuFileBackups_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(205, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(107, 22);
            this.mnuAboutHelp.Text = "&About";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);
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
            this.dgvHosts.Location = new System.Drawing.Point(3, 3);
            this.dgvHosts.MultiSelect = false;
            this.dgvHosts.Name = "dgvHosts";
            this.dgvHosts.Size = new System.Drawing.Size(599, 244);
            this.dgvHosts.TabIndex = 11;
            this.dgvHosts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHosts_CellValueChanged);
            this.dgvHosts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHosts_RowsRemoved);
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
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlAddHost);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(3, 247);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(599, 30);
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
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tabBasic);
            this.tabGroup.Controls.Add(this.tabAdvanced);
            this.tabGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGroup.Location = new System.Drawing.Point(0, 24);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.SelectedIndex = 0;
            this.tabGroup.Size = new System.Drawing.Size(613, 306);
            this.tabGroup.TabIndex = 13;
            this.tabGroup.SelectedIndexChanged += new System.EventHandler(this.tabGroup_SelectedIndexChanged);
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.SystemColors.Control;
            this.tabBasic.Controls.Add(this.dgvHosts);
            this.tabBasic.Controls.Add(this.pnlBottom);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(605, 280);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdvanced.Controls.Add(this.txtAdvanced);
            this.tabAdvanced.Controls.Add(this.pnlAdvancedBottom);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(605, 280);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            // 
            // txtAdvanced
            // 
            this.txtAdvanced.AcceptsReturn = true;
            this.txtAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdvanced.Location = new System.Drawing.Point(3, 3);
            this.txtAdvanced.Multiline = true;
            this.txtAdvanced.Name = "txtAdvanced";
            this.txtAdvanced.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdvanced.Size = new System.Drawing.Size(599, 244);
            this.txtAdvanced.TabIndex = 0;
            // 
            // pnlAdvancedBottom
            // 
            this.pnlAdvancedBottom.Controls.Add(this.btnAdvancedSave);
            this.pnlAdvancedBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdvancedBottom.Location = new System.Drawing.Point(3, 247);
            this.pnlAdvancedBottom.Name = "pnlAdvancedBottom";
            this.pnlAdvancedBottom.Size = new System.Drawing.Size(599, 30);
            this.pnlAdvancedBottom.TabIndex = 1;
            // 
            // btnAdvancedSave
            // 
            this.btnAdvancedSave.Location = new System.Drawing.Point(521, 4);
            this.btnAdvancedSave.Name = "btnAdvancedSave";
            this.btnAdvancedSave.Size = new System.Drawing.Size(75, 23);
            this.btnAdvancedSave.TabIndex = 0;
            this.btnAdvancedSave.Text = "Save";
            this.btnAdvancedSave.UseVisualStyleBackColor = true;
            this.btnAdvancedSave.Click += new System.EventHandler(this.btnAdvancedSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "hosts";
            this.dlgOpen.Filter = "Host Editor Files|*.hosts";
            this.dlgOpen.Title = "Import hosts File";
            // 
            // dlgExport
            // 
            this.dlgExport.DefaultExt = "hosts";
            this.dlgExport.Filter = "Host Editor Files|*.hosts";
            this.dlgExport.Title = "Export hosts File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 330);
            this.Controls.Add(this.tabGroup);
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
            this.tabGroup.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.pnlAdvancedBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvHosts;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlAddHost;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvHostsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHostsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHostsDomain;
        private System.Windows.Forms.TabControl tabGroup;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.TextBox txtAdvanced;
        private System.Windows.Forms.Panel pnlAdvancedBottom;
        private System.Windows.Forms.Button btnAdvancedSave;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgExport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileBackups;
    }
}

