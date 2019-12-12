using System;
using System.Text;

using FinanceManager.Models;

namespace FinanceManager.Repositories
{

    public class ReasonsRepository : AbstractRepository<Brother>
    {
        public ReasonsRepository() : base("allowedReasons.db") { }
    }

}
