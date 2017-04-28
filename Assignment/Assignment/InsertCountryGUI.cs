using System;
using System.Windows.Forms;
namespace Assignment
{
    public partial class InsertCountryGUI : Form
    {
        private readonly CountryTree _tree;
        public InsertCountryGUI(CountryTree tree)
        {
            InitializeComponent();
            _tree = tree;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(_tree.Has(txtName.Text)) {
                MessageBox.Show(@"Country with that name already exists in tree.");
                return;
            }
            if(!Country.Validate(txtName.Text, txtGDP.Text, txtInflation.Text, txtTradeBalance.Text, txtHDI.Text)) return;
            _tree.InsertItem(new Country(
                txtName.Text,
                float.Parse(txtGDP.Text),
                float.Parse(txtInflation.Text),
                float.Parse(txtTradeBalance.Text),
                int.Parse(txtHDI.Text)
            ));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}