
using FinanceManager.Models;

namespace FinanceManager.Repositories
{
    public class BrothersRepository : AbstractRepository<Brother>
    {
        public BrothersRepository() : base(@"db\brothers.db") { }
    }

}
