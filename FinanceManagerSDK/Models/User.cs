﻿using System;
using System.Text;

namespace FinanceManagerSDK.Models
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Account Account { get; }
        public Degree Degree { get; set; }

        public User()
        {
            Account = new Account();
        }
    }
}