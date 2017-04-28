using System.Collections.Generic;
using System.Linq;
namespace Assignment
{
    public class CountryTree : AVLTree<Country>
    {
        private readonly string[] _headers;
        public CountryTree(string[] headers) : base()
        {
            UpdateBestTradePartner();
            _headers = headers;
        }
        public Country BestTradePartner { get; set; }
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
        public Country[] Search(string query)
        {
            var results = new List<Country>();
            query = query.Trim().Replace(' ', '_');
            _search(query, root, ref results);
            return results.ToArray();
        }
        private static void _search(string query, Node<Country> root, ref List<Country> results)
        {
            while(root != null) {
                _search(query, root.Left, ref results);
                if(root.Data.Name.ToLower().Contains(query.ToLower()))
                    results.Add(root.Data);
                root = root.Right;
            }
        }
        public bool Has(string country)
        {
            return _has(country.Trim().ToLower(), root);
        }
        private static bool _has(string country, Node<Country> root)
        {
            return root != null && (root.Data.Name.Trim().ToLower().Equals(country) || _has(country, root.Left) || _has(country, root.Right));
        }
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
            var output = new List<string> {
                string.Join(",", _headers)
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
                var potential = country.MainTradePartners.Sum(partner => partner.GDPGrowth);
                if(potential <= bestPotential) continue;
                best = country;
                bestPotential = potential;
            }
            BestTradePartner = best;
        }
    }
}