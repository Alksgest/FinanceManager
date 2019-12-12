using System;
using System.Text;

using FinanceManager.Models;

namespace FinanceManager.Repositories
{

    public class ReasonsRepository : AbstractRepository<String>
    {
        public ReasonsRepository() : base(@"db\allowedReasons.db") { }
    }

}
