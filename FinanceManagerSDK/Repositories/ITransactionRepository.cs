using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetTransactions();

        void AddTransaction(Transaction tr);
    }

}
