
using FinanceManager.Models;

namespace FinanceManager.Repositories
{
    public class TransactionsRepository : AbstractRepository<Transaction>
    {
        public TransactionsRepository() : base("transactions.db") { }
    }

}
