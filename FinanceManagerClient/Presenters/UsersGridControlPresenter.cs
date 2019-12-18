using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Views;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerClient.Presenters
{
    class UsersGridControlPresenter : Presenter<IUsersView>
    {
        public event EventHandler DataSourceUpdated;

        private readonly IUserRepository _repo;

        public UsersGridControlPresenter(IUsersView view) : base(view)
        {
            _repo = new UserRepository();

            SetDataSoruce();
        }

        private void SetDataSoruce()
        {           
            View.DataSource = _repo.GetUsers();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
