using System;

namespace FinanceManagerSDK.Models
{
    public class TransactionReason
    {
        public const Int32 shortDescriptionMaxLength = 20;

        public int Id { get; set; }
        public String ShortDesctiption { get; set; }

        public String LongDesctiption { get; set; }

        public override string ToString()
        {
            return ShortDesctiption;
        }
    }
}
