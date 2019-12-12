
using FinanceManager.Models;

namespace FinanceManager.Repositories
{
    public class BrothersRepository : AbstractRepository<Brother>
    {
        public BrothersRepository() : base("brothers.db") { }
    }

}
