using System;

namespace FinanceManagerSDK.Models
{
    public class TransactionEventArgs: EventArgs
    {
        public Transaction Transaction { get; set; }

        public TransactionEventArgs(Transaction transaction): base()
        {
            Transaction = transaction;
        }
    }
}
