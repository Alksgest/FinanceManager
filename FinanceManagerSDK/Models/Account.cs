using System;
using System.Linq;
using System.Collections.Generic;

namespace FinanceManagerSDK.Models
{
    public class Account
    {
        //public decimal Balance { get; set; }

        public List<Tuple<Currency, decimal>> Operations = new List<Tuple<Currency, decimal>>();

        public override string ToString()
        {
            decimal uah = Operations.Where(o => o.Item1 == Currency.UAH).Sum(o => o.Item2);
            decimal usd = Operations.Where(o => o.Item1 == Currency.USD).Sum(o => o.Item2);
            decimal eur = Operations.Where(o => o.Item1 == Currency.EUR).Sum(o => o.Item2);

            return $"UAH = {uah}; USD = {usd}; EUR = {eur};";
        }
    }
}
