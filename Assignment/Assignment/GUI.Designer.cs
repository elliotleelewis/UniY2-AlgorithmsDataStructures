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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(596, 40);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // txtGDP
            // 
            this.txtGDP.Location = new System.Drawing.Point(244, 102);
            this.txtGDP.Name = "txtGDP";
            this.txtGDP.Size = new System.Drawing.Size(336, 31);
            this.txtGDP.TabIndex = 4;
            // 
            // lblGDP
            // 
            this.lblGDP.AutoSize = true;
            this.lblGDP.Location = new System.Drawing.Point(101, 105);
            this.lblGDP.Name = "lblGDP";
            this.lblGDP.Size = new System.Drawing.Size(137, 25);
            this.lblGDP.TabIndex = 3;
            this.lblGDP.Text = "GDP Growth:";
            this.lblGDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(244, 149);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(336, 31);
            this.txtInflation.TabIndex = 6;
            // 
            // lblInflation
            // 
            this.lblInflation.AutoSize = true;
            this.lblInflation.Location = new System.Drawing.Point(145, 152);
            this.lblInflation.Name = "lblInflation";
            this.lblInflation.Size = new System.Drawing.Size(93, 25);
            this.lblInflation.TabIndex = 5;
            this.lblInflation.Text = "Inflation:";
            this.lblInflation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTradeBalance
            // 
            this.txtTradeBalance.Location = new System.Drawing.Point(244, 196);
            this.txtTradeBalance.Name = "txtTradeBalance";
            this.txtTradeBalance.Size = new System.Drawing.Size(336, 31);
            this.txtTradeBalance.TabIndex = 8;
            // 
            // lblTradeBalance
            // 
            this.lblTradeBalance.AutoSize = true;
            this.lblTradeBalance.Location = new System.Drawing.Point(80, 199);
            this.lblTradeBalance.Name = "lblTradeBalance";
            this.lblTradeBalance.Size = new System.Drawing.Size(158, 25);
            this.lblTradeBalance.TabIndex = 7;
            this.lblTradeBalance.Text = "Trade Balance:";
            this.lblTradeBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHDI
            // 
            this.txtHDI.Location = new System.Drawing.Point(244, 243);
            this.txtHDI.Name = "txtHDI";
            this.txtHDI.Size = new System.Drawing.Size(336, 31);
            this.txtHDI.TabIndex = 10;
            // 
            // lblHDI
            // 
            this.lblHDI.AutoSize = true;
            this.lblHDI.Location = new System.Drawing.Point(127, 246);
            this.lblHDI.Name = "lblHDI";
            this.lblHDI.Size = new System.Drawing.Size(111, 25);
            this.lblHDI.TabIndex = 9;
            this.lblHDI.Text = "HDI Index:";
            this.lblHDI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Location = new System.Drawing.Point(24, 293);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(214, 25);
            this.lblPartners.TabIndex = 11;
            this.lblPartners.Text = "Main Trade Partners:";
            this.lblPartners.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.Location = new System.Drawing.Point(12, 53);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(568, 33);
            this.cmbCountry.TabIndex = 14;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // lstPartners
            // 
            this.lstPartners.FormattingEnabled = true;
            this.lstPartners.ItemHeight = 25;
            this.lstPartners.Location = new System.Drawing.Point(244, 290);
            this.lstPartners.Name = "lstPartners";
            this.lstPartners.Size = new System.Drawing.Size(336, 204);
            this.lstPartners.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 510);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(277, 44);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Country";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Location = new System.Drawing.Point(303, 510);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(277, 44);
            this.btnAddPartner.TabIndex = 17;
            this.btnAddPartner.Text = "Add Trade Partner";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 626);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.btnRemove);
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
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GUI";
            this.Text = "International Trading Data";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddPartner;
    }
}

