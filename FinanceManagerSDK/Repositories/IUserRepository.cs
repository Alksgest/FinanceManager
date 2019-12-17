
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User us);
        void UpdateUser(User us);
    }

}
