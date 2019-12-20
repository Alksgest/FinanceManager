using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class ContributionToGluPresenter : Presenter<IGridView>
    {
        public event EventHandler DataSourceUpdated;

        private readonly ITransactionManager _manager;

        public ContributionToGluPresenter(IGridView view) : base(view)
        {
            _manager = new TransactionManager();
            View.RefreshDataSource += OnRefresh;

            SetDataSoruce();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            SetDataSoruce();
        }

        public void SetDataSoruce()
        {
            SearchCriteria criteria = new SearchCriteria
            {
                TransactionType = TransactionType.Outcome,
            };

            View.DataSource = _manager.GetTransactions(criteria).ToList();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}

