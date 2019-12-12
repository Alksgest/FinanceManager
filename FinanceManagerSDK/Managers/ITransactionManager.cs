using System;
using System.Collections.Generic;

using FinanceManager.Models;

namespace FinanceManager.Managers
{
    public interface ITransactionManager
    {
        void AddTransaction(Transaction transaction);
        void RemoveTransaction(Transaction transaction);
        IEnumerable<Transaction> GetTransactions();
    }
}
