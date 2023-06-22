using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    public struct Currency
    {
        public string CurrencyString { get; set; }
        public double Amount { get; set; }

        public Currency(double amount, string currency)
        {
            Amount = amount;
            CurrencyString = currency;
        }
    }
}
