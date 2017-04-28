namespace Assignment
{
    partial class PartnersGUI
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblPartners = new System.Windows.Forms.Label();
            this.lstPartners = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(14, 14);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(65, 11);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(157, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Location = new System.Drawing.Point(11, 39);
            this.lblPartners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(49, 13);
            this.lblPartners.TabIndex = 2;
            this.lblPartners.Text = "Partners:";
            // 
            // lstPartners
            // 
            this.lstPartners.FormattingEnabled = true;
            this.lstPartners.Location = new System.Drawing.Point(65, 36);
            this.lstPartners.Name = "lstPartners";
            this.lstPartners.Size = new System.Drawing.Size(157, 108);
            this.lstPartners.TabIndex = 3;
            // 
            // PartnersGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 156);
            this.Controls.Add(this.lstPartners);
            this.Controls.Add(this.lblPartners);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartnersGUI";
            this.ShowInTaskbar = false;
            this.Text = "All Partners";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblPartners;
        private System.Windows.Forms.ListBox lstPartners;
    }
}