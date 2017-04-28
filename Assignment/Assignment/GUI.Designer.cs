namespace Assignment
{
    partial class GUI
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGDP = new System.Windows.Forms.TextBox();
            this.lblGDP = new System.Windows.Forms.Label();
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.lblInflation = new System.Windows.Forms.Label();
            this.txtTradeBalance = new System.Windows.Forms.TextBox();
            this.lblTradeBalance = new System.Windows.Forms.Label();
            this.txtHDI = new System.Windows.Forms.TextBox();
            this.lblHDI = new System.Windows.Forms.Label();
            this.lblPartners = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lstPartners = new System.Windows.Forms.ListBox();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtPotential = new System.Windows.Forms.TextBox();
            this.lblPotential = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemovePartner = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.countryToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(299, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.partnersToolStripMenuItem});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.insertToolStripMenuItem.Text = "Insert New";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // partnersToolStripMenuItem
            // 
            this.partnersToolStripMenuItem.Name = "partnersToolStripMenuItem";
            this.partnersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.partnersToolStripMenuItem.Text = "View All Partners";
            this.partnersToolStripMenuItem.Click += new System.EventHandler(this.partnersToolStripMenuItem_Click);
            // 
            // txtGDP
            // 
            this.txtGDP.Location = new System.Drawing.Point(122, 53);
            this.txtGDP.Margin = new System.Windows.Forms.Padding(2);
            this.txtGDP.Name = "txtGDP";
            this.txtGDP.Size = new System.Drawing.Size(170, 20);
            this.txtGDP.TabIndex = 4;
            this.txtGDP.TextChanged += new System.EventHandler(this.txtGDP_TextChanged);
            // 
            // lblGDP
            // 
            this.lblGDP.AutoSize = true;
            this.lblGDP.Location = new System.Drawing.Point(48, 56);
            this.lblGDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGDP.Name = "lblGDP";
            this.lblGDP.Size = new System.Drawing.Size(70, 13);
            this.lblGDP.TabIndex = 3;
            this.lblGDP.Text = "GDP Growth:";
            this.lblGDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(122, 77);
            this.txtInflation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(170, 20);
            this.txtInflation.TabIndex = 6;
            this.txtInflation.TextChanged += new System.EventHandler(this.txtInflation_TextChanged);
            // 
            // lblInflation
            // 
            this.lblInflation.AutoSize = true;
            this.lblInflation.Location = new System.Drawing.Point(71, 80);
            this.lblInflation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInflation.Name = "lblInflation";
            this.lblInflation.Size = new System.Drawing.Size(47, 13);
            this.lblInflation.TabIndex = 5;
            this.lblInflation.Text = "Inflation:";
            this.lblInflation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTradeBalance
            // 
            this.txtTradeBalance.Location = new System.Drawing.Point(122, 101);
            this.txtTradeBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtTradeBalance.Name = "txtTradeBalance";
            this.txtTradeBalance.Size = new System.Drawing.Size(170, 20);
            this.txtTradeBalance.TabIndex = 8;
            this.txtTradeBalance.TextChanged += new System.EventHandler(this.txtTradeBalance_TextChanged);
            // 
            // lblTradeBalance
            // 
            this.lblTradeBalance.AutoSize = true;
            this.lblTradeBalance.Location = new System.Drawing.Point(38, 104);
            this.lblTradeBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTradeBalance.Name = "lblTradeBalance";
            this.lblTradeBalance.Size = new System.Drawing.Size(80, 13);
            this.lblTradeBalance.TabIndex = 7;
            this.lblTradeBalance.Text = "Trade Balance:";
            this.lblTradeBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHDI
            // 
            this.txtHDI.Location = new System.Drawing.Point(122, 125);
            this.txtHDI.Margin = new System.Windows.Forms.Padding(2);
            this.txtHDI.Name = "txtHDI";
            this.txtHDI.Size = new System.Drawing.Size(170, 20);
            this.txtHDI.TabIndex = 10;
            this.txtHDI.TextChanged += new System.EventHandler(this.txtHDI_TextChanged);
            // 
            // lblHDI
            // 
            this.lblHDI.AutoSize = true;
            this.lblHDI.Location = new System.Drawing.Point(60, 128);
            this.lblHDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDI.Name = "lblHDI";
            this.lblHDI.Size = new System.Drawing.Size(58, 13);
            this.lblHDI.TabIndex = 9;
            this.lblHDI.Text = "HDI Index:";
            this.lblHDI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Location = new System.Drawing.Point(12, 152);
            this.lblPartners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(106, 13);
            this.lblPartners.TabIndex = 11;
            this.lblPartners.Text = "Main Trade Partners:";
            this.lblPartners.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.Location = new System.Drawing.Point(6, 28);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(286, 21);
            this.cmbCountry.TabIndex = 14;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // lstPartners
            // 
            this.lstPartners.FormattingEnabled = true;
            this.lstPartners.Location = new System.Drawing.Point(122, 149);
            this.lstPartners.Margin = new System.Windows.Forms.Padding(2);
            this.lstPartners.Name = "lstPartners";
            this.lstPartners.Size = new System.Drawing.Size(170, 108);
            this.lstPartners.TabIndex = 15;
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Location = new System.Drawing.Point(6, 207);
            this.btnAddPartner.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(112, 23);
            this.btnAddPartner.TabIndex = 17;
            this.btnAddPartner.Text = "Add";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtHeight);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtCount);
            this.grpInfo.Controls.Add(this.lblCount);
            this.grpInfo.Controls.Add(this.txtPotential);
            this.grpInfo.Controls.Add(this.lblPotential);
            this.grpInfo.Location = new System.Drawing.Point(6, 289);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(286, 100);
            this.grpInfo.TabIndex = 18;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Meta Information";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(132, 71);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(148, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tree Height:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(132, 45);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(148, 20);
            this.txtCount.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(40, 48);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(86, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "No. of Countries:";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPotential
            // 
            this.txtPotential.Location = new System.Drawing.Point(132, 19);
            this.txtPotential.Name = "txtPotential";
            this.txtPotential.ReadOnly = true;
            this.txtPotential.Size = new System.Drawing.Size(148, 20);
            this.txtPotential.TabIndex = 1;
            // 
            // lblPotential
            // 
            this.lblPotential.AutoSize = true;
            this.lblPotential.Location = new System.Drawing.Point(6, 22);
            this.lblPotential.Name = "lblPotential";
            this.lblPotential.Size = new System.Drawing.Size(120, 13);
            this.lblPotential.TabIndex = 0;
            this.lblPotential.Text = "Biggest Trade Potential:";
            this.lblPotential.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 261);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(286, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemovePartner
            // 
            this.btnRemovePartner.Location = new System.Drawing.Point(6, 234);
            this.btnRemovePartner.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePartner.Name = "btnRemovePartner";
            this.btnRemovePartner.Size = new System.Drawing.Size(112, 23);
            this.btnRemovePartner.TabIndex = 20;
            this.btnRemovePartner.Text = "Remove";
            this.btnRemovePartner.UseVisualStyleBackColor = true;
            this.btnRemovePartner.Click += new System.EventHandler(this.btnRemovePartner_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 396);
            this.Controls.Add(this.btnRemovePartner);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblPartners);
            this.Controls.Add(this.txtHDI);
            this.Controls.Add(this.lblHDI);
            this.Controls.Add(this.txtTradeBalance);
            this.Controls.Add(this.lblTradeBalance);
            this.Controls.Add(this.txtInflation);
            this.Controls.Add(this.lblInflation);
            this.Controls.Add(this.txtGDP);
            this.Controls.Add(this.lblGDP);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lstPartners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "International Trading Data";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGDP;
        private System.Windows.Forms.Label lblGDP;
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.Label lblInflation;
        private System.Windows.Forms.TextBox txtTradeBalance;
        private System.Windows.Forms.Label lblTradeBalance;
        private System.Windows.Forms.TextBox txtHDI;
        private System.Windows.Forms.Label lblHDI;
        private System.Windows.Forms.Label lblPartners;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ListBox lstPartners;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblPotential;
        private System.Windows.Forms.TextBox txtPotential;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Button btnRemovePartner;
    }
}

