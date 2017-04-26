using System.Collections.Generic;
namespace Assignment
{
    internal class CountryTree : AVLTree<Country>
    {
        public CountryTree() : base()
        {
            UpdateBestTradePartner();
        }
        public new void InsertItem(Country item)
        {
            base.InsertItem(item);
            UpdateBestTradePartner();
        }
        public new void RemoveItem(Country item)
        {
            base.RemoveItem(item);
            UpdateBestTradePartner();
        }
        public Country BestTradePartner { get; set; }
        public Country[] ToArray()
        {
            var list = new List<Country>();
            _toArray(root, ref list);
            return list.ToArray();
        }
        private static void _toArray(Node<Country> root, ref List<Country> list)
        {
            while(root != null) {
                _toArray(root.Left, ref list);
                list.Add(root.Data);
                root = root.Right;
            }
        }
        public string[] ToCSV()
        {
            var headers = new[] {
                "Country",
                "GDP growth",
                "Inflation",
                "Trade Balance",
                "HDI Ranking",
                "Main Trade Partners"
            };
            var output = new List<string> {
                string.Join(",", headers)
            };
            foreach(var country in ToArray()) {
                var temp = country.Name + ",";
                temp += country.GDPGrowth + ",";
                temp += country.Inflation + ",";
                temp += country.TradeBalance + ",";
                temp += country.HDIRanking + ",";
                var tradePartners = "";
                for(var i = 0; i < country.MainTradePartners.Length; i++) {
                    tradePartners += country.MainTradePartners[i];
                    if(i + 1 < country.MainTradePartners.Length)
                        tradePartners += ";";
                }
                tradePartners = "[" + tradePartners + "]";
                temp += tradePartners;
                output.Add(temp);
            }
            return output.ToArray();
        }
        public void UpdateBestTradePartner()
        {
            if(Count() == 0) return;
            var array = ToArray();
            var best = array[0];
            var bestPotential = 0f;
            for(var i = 1; i < array.Length; i++) {
                var country = array[i];
                var potential = 0f;
                foreach(var partner in country.MainTradePartners)
                    potential += partner.GDPGrowth;
                if(potential <= bestPotential) continue;
                best = country;
                bestPotential = potential;
            }
            BestTradePartner = best;
        }
    }
}