namespace Assignment
{
    partial class InsertCountryGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtHDI = new System.Windows.Forms.TextBox();
            this.lblHDI = new System.Windows.Forms.Label();
            this.txtTradeBalance = new System.Windows.Forms.TextBox();
            this.lblTradeBalance = new System.Windows.Forms.Label();
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.lblInflation = new System.Windows.Forms.Label();
            this.txtGDP = new System.Windows.Forms.TextBox();
            this.lblGDP = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHDI
            // 
            this.txtHDI.Location = new System.Drawing.Point(95, 107);
            this.txtHDI.Margin = new System.Windows.Forms.Padding(2);
            this.txtHDI.Name = "txtHDI";
            this.txtHDI.Size = new System.Drawing.Size(128, 20);
            this.txtHDI.TabIndex = 20;
            // 
            // lblHDI
            // 
            this.lblHDI.AutoSize = true;
            this.lblHDI.Location = new System.Drawing.Point(33, 110);
            this.lblHDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDI.Name = "lblHDI";
            this.lblHDI.Size = new System.Drawing.Size(58, 13);
            this.lblHDI.TabIndex = 19;
            this.lblHDI.Text = "HDI Index:";
            this.lblHDI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTradeBalance
            // 
            this.txtTradeBalance.Location = new System.Drawing.Point(95, 83);
            this.txtTradeBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtTradeBalance.Name = "txtTradeBalance";
            this.txtTradeBalance.Size = new System.Drawing.Size(128, 20);
            this.txtTradeBalance.TabIndex = 18;
            // 
            // lblTradeBalance
            // 
            this.lblTradeBalance.AutoSize = true;
            this.lblTradeBalance.Location = new System.Drawing.Point(11, 86);
            this.lblTradeBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTradeBalance.Name = "lblTradeBalance";
            this.lblTradeBalance.Size = new System.Drawing.Size(80, 13);
            this.lblTradeBalance.TabIndex = 17;
            this.lblTradeBalance.Text = "Trade Balance:";
            this.lblTradeBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(95, 59);
            this.txtInflation.Margin = new System.Windows.Forms.Padding(2);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(128, 20);
            this.txtInflation.TabIndex = 16;
            // 
            // lblInflation
            // 
            this.lblInflation.AutoSize = true;
            this.lblInflation.Location = new System.Drawing.Point(44, 62);
            this.lblInflation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInflation.Name = "lblInflation";
            this.lblInflation.Size = new System.Drawing.Size(47, 13);
            this.lblInflation.TabIndex = 15;
            this.lblInflation.Text = "Inflation:";
            this.lblInflation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGDP
            // 
            this.txtGDP.Location = new System.Drawing.Point(95, 35);
            this.txtGDP.Margin = new System.Windows.Forms.Padding(2);
            this.txtGDP.Name = "txtGDP";
            this.txtGDP.Size = new System.Drawing.Size(128, 20);
            this.txtGDP.TabIndex = 14;
            // 
            // lblGDP
            // 
            this.lblGDP.AutoSize = true;
            this.lblGDP.Location = new System.Drawing.Point(21, 38);
            this.lblGDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGDP.Name = "lblGDP";
            this.lblGDP.Size = new System.Drawing.Size(70, 13);
            this.lblGDP.TabIndex = 13;
            this.lblGDP.Text = "GDP Growth:";
            this.lblGDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 133);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(210, 23);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert Country";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // InsertCountryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 166);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHDI);
            this.Controls.Add(this.lblHDI);
            this.Controls.Add(this.txtTradeBalance);
            this.Controls.Add(this.lblTradeBalance);
            this.Controls.Add(this.txtInflation);
            this.Controls.Add(this.lblInflation);
            this.Controls.Add(this.txtGDP);
            this.Controls.Add(this.lblGDP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertCountryGUI";
            this.ShowInTaskbar = false;
            this.Text = "Insert Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHDI;
        private System.Windows.Forms.Label lblHDI;
        private System.Windows.Forms.TextBox txtTradeBalance;
        private System.Windows.Forms.Label lblTradeBalance;
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.Label lblInflation;
        private System.Windows.Forms.TextBox txtGDP;
        private System.Windows.Forms.Label lblGDP;
        private System.Windows.Forms.Button btnInsert;
    }
}