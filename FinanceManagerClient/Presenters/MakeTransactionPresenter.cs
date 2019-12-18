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

        private void OnTransactionStarted(object sender, Transaction tr)
        {
            Transaction builded = new Transaction
            {
                Amount = tr.Amount,
                TransactionOwner = tr.TransactionOwner,
                Comment = tr.Comment,
                Currency = tr.Currency,
                Date = tr.Date != null ? tr.Date : DateTime.Now,
                Reason = tr.Reason,
                Type = tr.Type, 
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
