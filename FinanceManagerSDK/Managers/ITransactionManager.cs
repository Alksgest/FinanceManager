using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Managers
{
    public interface ITransactionManager
    {
        void AddTransaction(Transaction transaction);
        void RemoveTransaction(Transaction transaction);
        IEnumerable<Transaction> GetTransactions();
    }
}
