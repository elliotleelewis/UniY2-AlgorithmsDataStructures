using System;
namespace Assignment
{
    internal class Country : IComparable
    {
        public string Name { get; set; }
        public float GDPGrowth { get; set; }
        public float Inflation { get; set; }
        public float TradeBalance { get; set; }
        public int HDIRanking { get; set; }
        public Country[] MainTradePartners { get; set; }
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