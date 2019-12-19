using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Managers
{
    public interface ITransactionProvider
    {
        void AddTransaction(Transaction transaction);
        IEnumerable<Transaction> GetTransactions();
        void RemoveTransaction(Transaction transaction);
    }
}