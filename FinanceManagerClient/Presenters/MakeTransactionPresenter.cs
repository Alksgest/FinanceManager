using System;
using System.Collections.Generic;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

using FinanceManagerClient.Views;

namespace FinanceManagerClient.Presenters
{
    // TODO dispose
    public class MakeTransactionPresenter : Presenter<IMakeTransactionView>
    {
        private readonly User CurrentUser = null;
        private readonly ITransactionRepository _transactionRepo = new TransactionRepository();
        private readonly IReasonRepository _reasonRepo = new ReasonRepository();
        private readonly IUserRepository _userRepo = new UserRepository();

        public IEnumerable<TransactionReason> Reasons { get; internal set; }
        public IEnumerable<User> Users { get; internal set; }

        public MakeTransactionPresenter(IMakeTransactionView view, User currentUser) : base(view) 
        {
            view.TransactionStarted += OnTransactionStarted;
            CurrentUser = currentUser;

            InitProperties();
        }

        private void InitProperties()
        {
            Reasons = _reasonRepo.GetReasons();
            Users = _userRepo.GetUsers();
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

            _transactionRepo.AddTransaction(builded);
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
        }
    }
}
