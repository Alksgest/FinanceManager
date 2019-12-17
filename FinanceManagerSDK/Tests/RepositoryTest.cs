using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

using NUnit.Framework;

namespace FinanceManagerSDK.Tests
{
    class RepositoryTest
    {

        private IUserRepository _repo;

        public RepositoryTest()
        {
            _repo = new UserRepository();
        }

        [Test]
        public void UserRepositoryTest()
        {
            //var user1 = new User
            //{
            //    Degree = Degree.First,
            //    Firstname = "Sus1",
            //    Lastname = "Kus1"
            //};

            //var user2 = new User
            //{
            //    Degree = Degree.Second,
            //    Firstname = "Sus2",
            //    Lastname = "Kus2"
            //};

            //_repo.AddUser(user1);

            //var users = _repo.GetUsers();

            //Assert.AreEqual(1, users.Count());

            //_repo.AddUser(user2);

            //var user_ = _repo.GetUsers().SingleOrDefault(u => u.Degree == Degree.Second);

            //Assert.AreEqual(user_, user2);
        }
    }
}
