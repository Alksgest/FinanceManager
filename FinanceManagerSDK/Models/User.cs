using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManagerSDK.Models
{
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

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Firstname == user.Firstname &&
                   Lastname == user.Lastname &&
                   Degree == user.Degree;
        }

        public override int GetHashCode()
        {
            var hashCode = 380988641;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lastname);
            hashCode = hashCode * -1521134295 + EqualityComparer<Account>.Default.GetHashCode(Account);
            hashCode = hashCode * -1521134295 + Degree.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
