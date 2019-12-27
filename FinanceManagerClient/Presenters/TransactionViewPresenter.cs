using System;
using System.Linq;
using System.ComponentModel;

using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class TransactionViewPresenter : Presenter<IGridView>
    {
        public event EventHandler DataSourceUpdated;

        private readonly ITransactionManager _manager;

        public TransactionViewPresenter(IGridView view) : base(view)
        {
            _manager = new TransactionManager();

            View.RefreshDataSoruceOnFocus += RefreshDataSource;

            GlobalSettings.Instance.OnTransactionAdded += OnTransactionsChanged;
        }

        private void OnTransactionsChanged(object sender, EventArgs e)
        {
            RefreshDataSource(sender, e);
        }

        private void RefreshDataSource(object sender, EventArgs e)
        {
            SetDataSoruce();
            DataSourceUpdated?.Invoke(sender, e);
        }

        public void SetDataSoruce()
        {
            SearchCriteria criteria = new SearchCriteria
            {
                TransactionType = TransactionType.Outcome,
            };

            View.TransactionsDataSource = _manager.GetTransactions(criteria).ToList();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}

