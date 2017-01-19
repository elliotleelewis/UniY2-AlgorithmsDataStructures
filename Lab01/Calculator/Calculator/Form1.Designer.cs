namespace Calculator
{
    partial class Form
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
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radMul = new System.Windows.Forms.RadioButton();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Location = new System.Drawing.Point(12, 15);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(113, 25);
            this.lblNumA.TabIndex = 0;
            this.lblNumA.Text = "Number A:";
            this.lblNumA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Location = new System.Drawing.Point(13, 59);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(113, 25);
            this.lblNumB.TabIndex = 1;
            this.lblNumB.Text = "Number B:";
            this.lblNumB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(131, 12);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(147, 31);
            this.txtNumA.TabIndex = 2;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(131, 56);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(147, 31);
            this.txtNumB.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 100);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(147, 31);
            this.txtResult.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(290, 25);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(55, 29);
            this.radAdd.TabIndex = 6;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "+";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(290, 60);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(50, 29);
            this.radSub.TabIndex = 7;
            this.radSub.TabStop = true;
            this.radSub.Text = "-";
            this.radSub.UseVisualStyleBackColor = true;
            // 
            // radMul
            // 
            this.radMul.AutoSize = true;
            this.radMul.Location = new System.Drawing.Point(290, 95);
            this.radMul.Name = "radMul";
            this.radMul.Size = new System.Drawing.Size(51, 29);
            this.radMul.TabIndex = 8;
            this.radMul.TabStop = true;
            this.radMul.Text = "*";
            this.radMul.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(352, 12);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(135, 119);
            this.btnEquals.TabIndex = 9;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 147);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.radMul);
            this.Controls.Add(this.radSub);
            this.Controls.Add(this.radAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblNumA);
            this.Name = "Form";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radMul;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.Button btnEquals;
    }
}

