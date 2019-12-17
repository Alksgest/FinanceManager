using System;
using System.Collections.Generic;
using System.Text;

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
