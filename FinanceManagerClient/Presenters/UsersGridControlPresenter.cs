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

            View.Refresh += OnRefresh;

            SetDataSoruce();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            SetDataSoruce();
        }

        public void SetDataSoruce()
        {           
            View.DataSource = _repo.GetUsers().ToList();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
