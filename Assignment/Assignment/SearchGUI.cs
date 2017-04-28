using System;
using System.Windows.Forms;
namespace Assignment
{
    public partial class SearchGUI : Form
    {
        private readonly GUI _parent;
        private readonly CountryTree _tree;
        public SearchGUI(GUI parent, CountryTree tree)
        {
            InitializeComponent();
            _parent = parent;
            _tree = tree;
            lstResults.DataSource = _tree.ToArray();
        }
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            lstResults.DataSource = _tree.Search(txtQuery.Text);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _parent.LoadCountry((Country) lstResults.SelectedItem);
            Close();
        }
    }
}