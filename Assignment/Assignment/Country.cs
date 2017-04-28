using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;
namespace Assignment
{
    public class Country : IComparable
    {
        public Country(string name, float gdpGrowth, float inflation, float tradeBalance, int hdiRanking)
        {
            Name = name.Trim().Replace(' ', '_');
            GDPGrowth = gdpGrowth;
            Inflation = inflation;
            TradeBalance = tradeBalance;
            HDIRanking = hdiRanking;
            MainTradePartners = new Country[0];
        }
        public string Name { get; set; }
        public float GDPGrowth { get; set; }
        public float Inflation { get; set; }
        public float TradeBalance { get; set; }
        public int HDIRanking { get; set; }
        public Country[] MainTradePartners { get; set; }
        public static bool Validate(string name, string gdpGrowth, string inflation, string tradeBalance, string hdiRanking)
        {
            if(name.Length != 0 && name.All(char.IsLetter)) return Validate(gdpGrowth, inflation, tradeBalance, hdiRanking);
            MessageBox.Show(@"Invalid Name value.");
            return false;
        }
        [SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
        public static bool Validate(string gdpGrowth, string inflation, string tradeBalance, string hdiRanking)
        {
            try {
                float.Parse(gdpGrowth);
            }
            catch(Exception) {
                MessageBox.Show(@"Invalid GDP Growth value.");
                return false;
            }
            try {
                float.Parse(inflation);
            }
            catch(Exception) {
                MessageBox.Show(@"Invalid Inflation value.");
                return false;
            }
            try {
                float.Parse(tradeBalance);
            }
            catch(Exception) {
                MessageBox.Show(@"Invalid Trade Balance value.");
                return false;
            }
            try {
                int.Parse(hdiRanking);
            }
            catch(Exception) {
                MessageBox.Show(@"Invalid HDI Ranking value.");
                return false;
            }
            return true;
        }
        public int CompareTo(object obj)
        {
            return string.Compare(Name, ((Country) obj).Name, StringComparison.Ordinal);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}