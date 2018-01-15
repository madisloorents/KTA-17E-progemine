using System;

namespace tunnitoo_15._01._2018
{
    public class Restaurant
    {
        private string _nimi;
        private string _aadress;

        public Restaurant(string nimi, string aadress)
        {
            _nimi = nimi;
            _aadress = aadress;
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(_nimi, _aadress, tab);
        }
    }
}