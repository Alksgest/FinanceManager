using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagerSDK.Models
{
    public class SearchCriteria
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public TransactionType? TransactionType { get; set; }
        public User TransactionOwner { get; set; }
        public TransactionReason Reason { get; set; }
        public Decimal? Amount { get; set; }
        public Currency? Currency { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
