using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Assignment
{
    public partial class GUI : Form
    {
        private CountryTree _tree;
        private Country _selectedCountry;
        private bool _changes;
        public GUI()
        {
            InitializeComponent();
            _updateGUI();
        }
        private bool Changes
        {
            set {
                _changes = value;
                _updateSaveState();
            }
            get => _changes;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _promptLoadCSV();
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _promptExportCSV();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _refreshGUI();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = (new InsertCountryGUI(_tree)).ShowDialog();
            if(dialog == DialogResult.OK)
                _refreshGUI();
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchGUI(this, _tree)).ShowDialog();
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure to remove this country?", @"Confirm Removal", MessageBoxButtons.YesNo);
            if(dialogResult != DialogResult.Yes) return;
            _tree.RemoveItem(_selectedCountry);
            _refreshGUI();
        }
        private void partnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new PartnersGUI(_tree, _selectedCountry)).ShowDialog();
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCountry((Country) ((ComboBox) sender).SelectedItem);
        }
        private void txtGDP_TextChanged(object sender, EventArgs e)
        {
            Changes = true;
        }
        private void txtInflation_TextChanged(object sender, EventArgs e)
        {
            Changes = true;
        }
        private void txtTradeBalance_TextChanged(object sender, EventArgs e)
        {
            Changes = true;
        }
        private void txtHDI_TextChanged(object sender, EventArgs e)
        {
            Changes = true;
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            var dialog = (new AddPartnerGUI(this, (Country[]) cmbCountry.DataSource)).ShowDialog();
            if(dialog != DialogResult.OK) return;
            btnRemovePartner.Enabled = ((Country[]) lstPartners.DataSource).Length > 0;
            Changes = true;
        }
        private void btnRemovePartner_Click(object sender, EventArgs e)
        {
            lstPartners.DataSource = ((Country[]) lstPartners.DataSource).Where(country => country != (Country) lstPartners.SelectedItem).ToArray();
            btnRemovePartner.Enabled = ((Country[]) lstPartners.DataSource).Length > 0;
            Changes = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_selectedCountry == null || !Country.Validate(txtGDP.Text, txtInflation.Text, txtTradeBalance.Text, txtHDI.Text)) return;
            _selectedCountry.GDPGrowth = float.Parse(txtGDP.Text);
            _selectedCountry.Inflation = float.Parse(txtInflation.Text);
            _selectedCountry.TradeBalance = float.Parse(txtTradeBalance.Text);
            _selectedCountry.HDIRanking = int.Parse(txtHDI.Text);
            _selectedCountry.MainTradePartners = (Country[]) lstPartners.DataSource;
            _tree.UpdateBestTradePartner();
            _updateGUI();
        }
        public void LoadCountry(Country country)
        {
            cmbCountry.SelectedItem = country;
            _selectedCountry = country;
            _updateGUI();
        }
        private void _refreshGUI()
        {
            if(_tree == null) return;
            cmbCountry.DataSource = _tree.ToArray();
            _updateGUI();
        }
        private void _updateGUI()
        {
            _updateGUIState();
            if(_tree != null) {
                txtPotential.Text = _tree.BestTradePartner.ToString();
                txtCount.Text = _tree.Count().ToString();
                txtHeight.Text = _tree.Height().ToString();
                if(_selectedCountry == null) {
                    txtGDP.Text = "";
                    txtInflation.Text = "";
                    txtTradeBalance.Text = "";
                    txtHDI.Text = "";
                    lstPartners.DataSource = null;
                }
                else {
                    txtGDP.Text = "" + _selectedCountry.GDPGrowth;
                    txtInflation.Text = "" + _selectedCountry.Inflation;
                    txtTradeBalance.Text = "" + _selectedCountry.TradeBalance;
                    txtHDI.Text = "" + _selectedCountry.HDIRanking;
                    lstPartners.DataSource = _selectedCountry.MainTradePartners;
                }
            }
            Changes = false;
        }
        private void _updateGUIState()
        {
            if(cmbCountry.Enabled != (_tree != null))
                cmbCountry.Enabled = (_tree != null);
            var treeState = (_tree == null);
            var selectedState = (_selectedCountry == null);
            exportToolStripMenuItem.Enabled = !treeState;
            refreshToolStripMenuItem.Enabled = !treeState;
            insertToolStripMenuItem.Enabled = !treeState;
            searchToolStripMenuItem.Enabled = !treeState;
            removeToolStripMenuItem.Enabled = !selectedState;
            partnersToolStripMenuItem.Enabled = !selectedState;
            txtGDP.ReadOnly = selectedState;
            txtInflation.ReadOnly = selectedState;
            txtTradeBalance.ReadOnly = selectedState;
            txtHDI.ReadOnly = selectedState;
            lstPartners.Enabled = !selectedState;
            btnAddPartner.Enabled = !selectedState;
            btnRemovePartner.Enabled = !selectedState && _selectedCountry.MainTradePartners.Length > 0;
        }
        private void _updateSaveState()
        {
            btnSave.Enabled = Changes;
        }
        private void _loadCSV(string filepath)
        {
            try {
                var file = File.ReadAllLines(filepath);
                var data = file.Skip(1).ToArray();
                _tree = new CountryTree(file[0].Split(','));
                var countries = (from line in data where line.Trim().Length != 0 select line.Split(',')).ToDictionary(
                    fields => fields[0], fields => new Country(
                        fields[0],
                        float.Parse(fields[1]),
                        float.Parse(fields[2]),
                        float.Parse(fields[3]),
                        int.Parse(fields[4])
                    )
                );
                var i = 0;
                foreach(var country in countries) {
                    var tradingString = data[i].Split(',')[5];
                    tradingString = tradingString.Substring(1, tradingString.Length - 2);
                    var tradingArray = tradingString.Split(';');
                    country.Value.MainTradePartners = tradingArray.Select(tradingPartner => countries[tradingPartner])
                        .ToArray();
                    _tree.InsertItem(country.Value);
                    i++;
                }
            }
            catch(Exception) {
                MessageBox.Show(@"Unable to successfully read CSV file.");
                _tree = null;
            }
            _refreshGUI();
        }
        private void _exportCSV(string filepath)
        {
            if(_tree == null) {
                MessageBox.Show(@"Please open a CSV file first.");
                return;
            }
            File.WriteAllLines(filepath, _tree.ToCSV());
        }
        private void _promptLoadCSV()
        {
            var dialog = new OpenFileDialog {
                Filter = @"CSV files|*.csv"
            };
            if(dialog.ShowDialog() == DialogResult.OK)
                _loadCSV(dialog.FileName);
        }
        private void _promptExportCSV()
        {
            var dialog = new SaveFileDialog {
                Title = @"Export",
                Filter = @"CSV file|*.csv"
            };
            if(dialog.ShowDialog() == DialogResult.OK)
                _exportCSV(dialog.FileName);
        }
        public void AddPartner(Country country)
        {
            var countries = ((Country[]) lstPartners.DataSource).ToList();
            countries.Add(country);
            lstPartners.DataSource = countries.ToArray();
        }
    }
}