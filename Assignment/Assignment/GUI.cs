using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Assignment
{
    public partial class GUI : Form
    {
        private CountryTree _tree;
        private Country _selectedCountry;
        public GUI()
        {
            InitializeComponent();
            _updateGUI();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _promptLoadCSV();
            _updateGUI();
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _promptExportCSV();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_tree == null) {
                MessageBox.Show(@"Please open a CSV file first.");
                return;
            }
            //TODO Launch smaller GUI with info about CountryTree (height, country count, etc.)
            foreach(var line in _tree.ToCSV()) {
                Console.WriteLine(line);
            }
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loadCountry((Country) ((ComboBox) sender).SelectedItem);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure to remove this country?", @"Confirm Removal", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) {
                _tree.RemoveItem(_selectedCountry);
                cmbCountry.DataSource = null;
                _updateGUI();
            }
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            //TODO Add partner.
        }
        private void _loadCountry(Country country)
        {
            _selectedCountry = country;
            _updateGUI();
        }
        private void _updateGUI()
        {
            _updateGUIState();
            if(_tree == null) return;
            if(cmbCountry.DataSource == null)
                cmbCountry.DataSource = _tree.ToArray();
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
        private void _updateGUIState()
        {
            if(cmbCountry.Enabled != (_tree != null))
                cmbCountry.Enabled = (_tree != null);
            var state = (_selectedCountry == null);
            txtGDP.ReadOnly = state;
            txtInflation.ReadOnly = state;
            txtTradeBalance.ReadOnly = state;
            txtHDI.ReadOnly = state;
            lstPartners.Enabled = !state;
            btnRemove.Enabled = !state;
        }
        private void _loadCSV(string filepath)
        {
            try {
                var lines = File.ReadAllLines(filepath).Skip(1).ToArray();
                _tree = new CountryTree();
                var countries = new Dictionary<string, Country>();
                foreach(var line in lines) {
                    if(line.Trim().Length == 0) continue;
                    var fields = line.Split(',');
                    countries.Add(fields[0], new Country {
                        Name = fields[0],
                        GDPGrowth = float.Parse(fields[1]),
                        Inflation = float.Parse(fields[2]),
                        TradeBalance = float.Parse(fields[3]),
                        HDIRanking = int.Parse(fields[4])
                    });
                }
                var i = 0;
                foreach(var country in countries) {
                    var tradingString = lines[i].Split(',')[5];
                    tradingString = tradingString.Substring(1, tradingString.Length - 2);
                    var tradingArray = tradingString.Split(';');
                    var mainTradingPartners = new List<Country>();
                    foreach(var tradingPartner in tradingArray) {
                        mainTradingPartners.Add(countries[tradingPartner]);
                    }
                    country.Value.MainTradePartners = mainTradingPartners.ToArray();
                    _tree.InsertItem(country.Value);
                    i++;
                }
            }
            catch(Exception) {
                MessageBox.Show(@"Unable to successfully read CSV file.");
                _tree = null;
            }
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
            if(dialog.ShowDialog() == DialogResult.OK) {
                _loadCSV(dialog.FileName);
            }
        }
        private void _promptExportCSV()
        {
            //TODO
            var dialog = new SaveFileDialog {
                Filter = @"CSV file|*.csv"
            };
            if(dialog.ShowDialog() == DialogResult.OK) {
                _exportCSV(dialog.FileName);
            }
        }
    }
}