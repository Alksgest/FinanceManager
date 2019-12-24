using System;
using System.Windows.Forms;
using System.Collections.Generic;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Managers;

using FinanceManagerClient.Views;
using FinanceManagerClient.Util;

namespace FinanceManagerClient.Presenters
{
    public class MakeTransactionPresenter : Presenter<IMakeTransactionView>
    {
        private readonly User CurrentUser = null;
        private readonly ITransactionManager _manager;

        public IEnumerable<TransactionReason> Reasons => GlobalSettings.Instance.TransactionReasons;
        public IEnumerable<User> Users => GlobalSettings.Instance.Users;

        public MakeTransactionPresenter(IMakeTransactionView view, User currentUser) : base(view) 
        {
            _manager = new TransactionManager();
            _manager.TransactionDone += OnTransactionDone;

            view.TransactionStarted += OnTransactionStarted;
            CurrentUser = currentUser;       
        }

        private void OnTransactionDone(TransactionEventArgs obj)
        {
            GlobalSettings.Instance.TransactionAddedInvokation(this);
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

            _manager.MakeTransaction(builded);
            (View as Form).Close();
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
        }
    }
}
