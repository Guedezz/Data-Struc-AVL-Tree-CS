using System.Collections.Generic;

namespace ADSAssignment
{
    public class AVLCountry : AVLTree<Country>
    {
        public List<Country> GetAllCountries()
        {
            List<Country> allCountries = new List<Country>();
            getAllCountries(root, allCountries);
            return allCountries;
        }
        private void getAllCountries(Node<Country> countryNode, List<Country> allCountries)
        {
            if (countryNode != null)
            {
                getAllCountries(countryNode.Left, allCountries);
                allCountries.Add(countryNode.Data);
                getAllCountries(countryNode.Right, allCountries);
            }
        }

        public AVLCountry fetchAllTradePartners(Country country)
        {
            AVLCountry tradePartners = new AVLCountry();
            foreach (string partnerName in country.TradePartners)
            {
                foreach (Country c in GetAllCountries())
                {
                    if (c.CountryName==partnerName)
                        tradePartners.InsertItem(c);
                }
            }
            return tradePartners;
        }
    }
}
