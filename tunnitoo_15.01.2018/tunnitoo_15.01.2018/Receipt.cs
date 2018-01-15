

namespace tunnitoo_15._01._2018
{
    using System.Linq;
    using System.Text;

    public class Receipt
    {
        private string _restorannimi;
        private string _restoranaadress;
        private Tab _tab;
        

        public Receipt(string restorannimi, string restoranaadress, Tab tab)
        {
            _restorannimi = restorannimi;
            _restoranaadress = restoranaadress;
            _tab = tab;
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(_restorannimi);
            sb.AppendLine(_restoranaadress);
                        
            sb.AppendLine("-------------------------------");

            foreach (var entry in _tab.Entries)
            {
                sb.AppendLine($"Price of food item: {entry}");
            }

            var totalentries = _tab.Entries.Sum();

            sb.AppendLine($"Subtotal: €{_tab.Entries.Sum()}");
            sb.AppendLine($"15% Grauity: €{_tab.Entries.Sum() * 0.15:F2}");
            sb.AppendLine($"Total: €{_tab.Entries.Sum() * 0.85:F2}");
            sb.AppendLine();
            

            return sb.ToString();
        }
    }
}