using System.Linq;
using System.Collections.Generic;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerSDK.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _repo;

        public UserManager()
        {
            _repo = new UserRepository();
        }

        public void AddUser(User user) => _repo.AddUser(user);

        public User GetUser(string lastname, Degree degree)
        {
            return _repo.GetUsers().SingleOrDefault(u => u.Lastname == lastname && u.Degree == degree);
        }

        public IEnumerable<User> Users => _repo.GetUsers();

        public bool UserExists(string lastname, Degree degree)
        {
            var user = _repo.GetUsers().SingleOrDefault(u => u.Lastname == lastname && u.Degree == degree);
            return user != null;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repo.GetUsers();
        }
    }
}
