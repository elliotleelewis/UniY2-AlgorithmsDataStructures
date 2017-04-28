using System.Linq;
using System.Windows.Forms;
namespace Assignment
{
    public partial class PartnersGUI : Form
    {
        public PartnersGUI(CountryTree tree, Country selectedCountry)
        {
            InitializeComponent();
            txtCountry.Text = selectedCountry.ToString();
            var countries = tree.ToArray().Where(country => country.MainTradePartners.Contains(selectedCountry)).ToList();
            foreach(var country in selectedCountry.MainTradePartners) {
                if(!countries.Contains(country))
                    countries.Add(country);
            }
            countries.Sort();
            lstPartners.DataSource = countries;
        }
    }
}