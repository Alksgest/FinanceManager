using System;

namespace FinanceManagerSDK.Models
{
    public class TransactionReason
    {
        public const Int32 shortDescriptionMaxLength = 20;

        public int Id { get; set; }
        public String ShortDesctiption { get; set; }

        public String LongDesctiption { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TransactionReason reason &&
                   Id == reason.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return ShortDesctiption;
        }
    }
}
