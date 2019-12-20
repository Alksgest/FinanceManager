using FinanceManagerSDK.Models;
using System;
using System.Collections.Generic;

namespace FinanceManagerSDK.Managers
{
    public interface ITransactionManager
    {
        event Action<TransactionEventArgs> TransactionDone;
        event Action<TransactionEventArgs> TransactionStarted;

        DateTime GetFirstTransactionTime();
        DateTime GetLastTransactionTime();
        IEnumerable<Transaction> GetTransactions(SearchCriteria criteria);
        void MakeTransaction(Transaction transaction);
    }
}