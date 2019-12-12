using FinanceManager.Models;
using FinanceManager.Repositories;
using FinanceManagerClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagerClient.Presenters
{
    public class MakeTransactionPresenter : Presenter<IMakeTransactionView>
    {

        private readonly TransactionsRepository _repo = new TransactionsRepository();

        public MakeTransactionPresenter(IMakeTransactionView view) : base(view) 
        {
            view.TransactionStarted += OnViewTransactionStarted;
        }

        private void OnViewTransactionStarted(Transaction row)
        {
            Transaction builded = new Transaction
            {
                Amount = row.Amount,
                Brother = row.Brother,
                Comment = row.Comment,
                Currency = row.Currency,
                Date = row.Date != null ? row.Date : DateTime.Now,
                Reason = row.Reason,
                Type = row.Type
            };

            _repo.AddObject(builded);
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
        }
    }
}
