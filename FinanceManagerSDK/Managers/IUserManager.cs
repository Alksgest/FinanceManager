using System;
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Managers
{
    public interface IUserManager
    {
        IEnumerable<User> GetUsers();

        bool UserExists(String surname, Degree degree);
        void AddUser(User user);
        User GetUser(string lastname, Degree degree);
    }
}
