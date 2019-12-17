using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Args
{
    public class LoginEventArgs : EventArgs
    {
        public String Lastname { get; set; }
        public Degree Degree { get; set; }
    }
}
