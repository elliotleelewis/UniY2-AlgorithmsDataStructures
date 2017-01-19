using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int numA = Convert.ToInt32(txtNumA.Text);
            int numB = Convert.ToInt32(txtNumB.Text);
            if (radAdd.Checked) {
                txtResult.Text = (numA + numB).ToString();
            }
            else if (radSub.Checked)
            {
                txtResult.Text = (numA - numB).ToString();
            }
            if (radMul.Checked)
            {
                txtResult.Text = (numA * numB).ToString();
            }
        }
    }
}
