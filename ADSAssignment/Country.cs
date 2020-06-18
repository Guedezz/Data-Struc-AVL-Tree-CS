using System;
using System.Collections.Generic;

namespace ADSAssignment
{
    public class Country : IComparable
    {
        string countryName;
        double gdpGrowth;
        double inflation;
        double tradeBalance;
        int hdiRanking;
        private LinkedList<String> mainTradePartners = null;

        //constructor
        public Country(){}

        //constructor
        public Country(string countryName)
        {
            this.countryName = countryName;
        }
        
        //constructor
        public Country(string countryName, double gdpGrowth, double inflation, double tradeBalance, int hdiRanking, LinkedList<string> tradePartners)
        {
            this.countryName = countryName;
            this.gdpGrowth = gdpGrowth;
            this.inflation = inflation;
            this.tradeBalance = tradeBalance;
            this.hdiRanking = hdiRanking;
            this.mainTradePartners = tradePartners;
        }

        public String CountryName
        {   get { return countryName; }
            set { countryName = value; }
        }

        public double GDPGrowth
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public double Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public double TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }
        public int HDIRanking
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

        public LinkedList<String> TradePartners
        {
            get { return mainTradePartners; }
            set { mainTradePartners = value; }
        }
        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return countryName.CompareTo(temp.countryName);
        }
    }
}
