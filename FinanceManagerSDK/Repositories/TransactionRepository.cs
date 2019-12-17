
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{
    public class TransactionRepository : AbstractRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository() : base(@"db\transactions.db") { }
        public TransactionRepository(string dbString) : base(dbString) { }

        public IEnumerable<Transaction> GetTransactions()
        {
            return this.GetObjects();
        }

        public void AddTransaction(Transaction tr)
        {
            this.AddObject(tr);
        }

    }

}
