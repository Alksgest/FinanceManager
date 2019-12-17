using System;
using System.Collections.Generic;

namespace FinanceManagerSDK.Models
{
    public class Account
    {
        public Dictionary<Currency, double> Balance = new Dictionary<Currency, double>();
    }
}
