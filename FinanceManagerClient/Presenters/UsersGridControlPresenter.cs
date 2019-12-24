using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Views;
using FinanceManagerSDK.Managers;

namespace FinanceManagerClient.Presenters
{
    class UsersGridControlPresenter : Presenter<IGridView>
    {
        public event EventHandler DataSourceUpdated;

        private readonly IUserManager _manager;

        public UsersGridControlPresenter(IGridView view) : base(view)
        {
            _manager = new UserManager();

            SetDataSoruce();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            SetDataSoruce();
        }

        public void SetDataSoruce()
        {           
            View.TransactionsDataSource = _manager.GetUsers().ToList();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
