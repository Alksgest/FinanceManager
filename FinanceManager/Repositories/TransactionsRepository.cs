
using FinanceManager.Models;

namespace FinanceManager.Repositories
{
    public class TransactionsRepository : AbstractRepository<Transaction>
    {
        public TransactionsRepository() : base(@"db\transactions.db") { }
        public TransactionsRepository(string dbString) : base(dbString) { }
    }

}
