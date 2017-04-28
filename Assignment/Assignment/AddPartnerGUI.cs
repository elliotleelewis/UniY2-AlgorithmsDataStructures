using System;
using System.Collections;
using System.Windows.Forms;
namespace Assignment
{
    public partial class AddPartnerGUI : Form
    {
        private readonly GUI _parent;
        public AddPartnerGUI(GUI parent, IEnumerable countries)
        {
            InitializeComponent();
            _parent = parent;
            cmbCountries.DataSource = countries;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parent.AddPartner((Country) cmbCountries.SelectedItem);
        }
    }
}