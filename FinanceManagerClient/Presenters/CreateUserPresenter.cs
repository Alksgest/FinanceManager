using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class CreateUserPresenter : Presenter<ICreateUserView>
    {

        private readonly IUserManager _manager;

        public CreateUserPresenter(ICreateUserView view) : base(view)
        {
            View.UserCreation += OnUserCreation;

            _manager = new UserManager();
        }

        private void OnUserCreation(object sender, User e)
        {
            _manager.AddUser(e);
            GlobalSettings.Instance.Users = _manager.GetUsers();
        }
    }
}
