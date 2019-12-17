using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManagerSDK.Models
{
    [Serializable]
    public class Account 
    {
        public Dictionary<Currency, double> Balance = new Dictionary<Currency, double>();
    }

    public enum Degree 
    {
        First,
        Second,
        Third
    }

    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Account Account { get; set; }
        public Degree Degree { get; set; }

        public User()
        {
            Account = new Account();
        }
    }
}
