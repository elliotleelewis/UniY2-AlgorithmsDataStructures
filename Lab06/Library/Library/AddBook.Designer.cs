namespace Library
{
    partial class AddBook
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
            this.LabelISBN = new System.Windows.Forms.Label();
            this.TextISBN = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelISBN
            // 
            this.LabelISBN.AutoSize = true;
            this.LabelISBN.Location = new System.Drawing.Point(13, 13);
            this.LabelISBN.Name = "LabelISBN";
            this.LabelISBN.Size = new System.Drawing.Size(66, 25);
            this.LabelISBN.TabIndex = 0;
            this.LabelISBN.Text = "ISBN:";
            this.LabelISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextISBN
            // 
            this.TextISBN.Location = new System.Drawing.Point(85, 10);
            this.TextISBN.Name = "TextISBN";
            this.TextISBN.Size = new System.Drawing.Size(369, 31);
            this.TextISBN.TabIndex = 1;
            // 
            // TextTitle
            // 
            this.TextTitle.Location = new System.Drawing.Point(85, 57);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(369, 31);
            this.TextTitle.TabIndex = 3;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(20, 60);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(59, 25);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Title:";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(18, 104);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(436, 46);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add Book";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 168);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextTitle);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextISBN);
            this.Controls.Add(this.LabelISBN);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.TextBox TextISBN;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonAdd;
    }
}