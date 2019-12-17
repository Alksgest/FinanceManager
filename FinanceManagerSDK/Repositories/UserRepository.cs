
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository() : base(@"db\brothers.db") { }
        public UserRepository(string dbString) : base(dbString) { }

        public IEnumerable<User> GetUsers()
        {
            return this.GetObjects();
        }

        public void AddUser(User us)
        {
            this.AddObject(us);
        }

        public void UpdateUser(User us)
        {
            this.UpdateObject(us);
        }
    }
}
