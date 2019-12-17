using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerClient.Presenters
{
    class CreateUserPresenter : Presenter<ICreateUserView>
    {

        private readonly IUserRepository _repo;

        public CreateUserPresenter(ICreateUserView view) : base(view)
        {
            View.UserCreation += OnUserCreation;

            _repo = new UserRepository();
        }

        private void OnUserCreation(object sender, User e)
        {
            _repo.AddUser(e);
        }
    }
}
