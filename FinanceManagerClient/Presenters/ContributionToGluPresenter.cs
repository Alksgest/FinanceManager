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

        private IEnumerable<Transaction> FilterTransactions()
        {
            return _manager.GetAllTransactions()
                .Where(tr => tr.Type == TransactionType.Outcome 
                    && IsReasonCorrect(tr.Reason.ShortDesctiption));
        }

        private bool IsReasonCorrect(string shortDescription)
        {
            string s = shortDescription.Trim().ToLower();
            return s.Contains("glu") || s.Contains("glou") || s.Contains("contribution");
        }

        public void SetDataSoruce()
        {
            View.DataSource = FilterTransactions().ToList();
            DataSourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}

