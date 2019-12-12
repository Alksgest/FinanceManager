using System;
using System.Text;

using FinanceManager.Models;

namespace FinanceManager.Repositories
{

    public class ReasonsRepository : AbstractRepository<TransactionReason>
    {
        public ReasonsRepository() : base(@"db\allowedReasons.db") { }

        public ReasonsRepository(string dbString) : base(dbString) { }
    }

}
