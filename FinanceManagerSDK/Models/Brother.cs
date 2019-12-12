using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Models
{
    [Serializable]
    public class Account 
    {
        public Dictionary<Currency, double> Balance = new Dictionary<Currency, double>();
    }

    [Serializable]
    public class Brother
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Account Account { get; set; }

        public Brother()
        {
            Account = new Account();
        }
    }
}
