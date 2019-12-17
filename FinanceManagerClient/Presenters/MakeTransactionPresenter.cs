using System;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

using FinanceManagerClient.Views;

namespace FinanceManagerClient.Presenters
{
    public class MakeTransactionPresenter : Presenter<IMakeTransactionView>
    {
        private readonly ITransactionRepository _repo = new TransactionRepository();
        private readonly User CurrentUser;

        public MakeTransactionPresenter(IMakeTransactionView view, User currentUser) : base(view) 
        {
            view.TransactionStarted += OnTransactionStarted;
            CurrentUser = currentUser;
        }

        private void OnTransactionStarted(Transaction row)
        {
            Transaction builded = new Transaction
            {
                Amount = row.Amount,
                TransactionOwner = row.TransactionOwner,
                Comment = row.Comment,
                Currency = row.Currency,
                Date = row.Date != null ? row.Date : DateTime.Now,
                Reason = row.Reason,
                Type = row.Type, 
                TransactionMaker = CurrentUser
            };

            _repo.AddTransaction(builded);
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
        }
    }
}
