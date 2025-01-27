﻿using System;
using System.Collections.Generic;
using FinanceManagerSDK.Models;
using FinanceManagerClient.Views;

namespace FinanceManagerClient.Presenters
{
    class MainPresenter : Presenter<IMainView>
    {

        private readonly User _currentUser;

        public MainPresenter(IMainView view, User user) : base(view)
        {
            _currentUser = user;

            this.View.MakeTransaction += OnMakeTransactionClicked;
            this.View.AddUser += OnAddUser;
            this.View.AddReason += OnAddReason;
            this.View.AddCriteria += OnAddCriteria;
        }

        private void OnAddCriteria(object sender, EventArgs e)
        {
            using(var form = new CreateCriteriaForm())
            {
                form.ShowDialog();
            }
        }

        private void OnAddReason(object sender, EventArgs e)
        {
            using(var form = new AddReasonForm())
            {
                form.ShowDialog();
            }
        }

        private void OnAddUser(object sender, EventArgs e)
        {
            using(var form = new CreateUserForm())
            {
                form.ShowDialog();
            }
        }

        private void OnMakeTransactionClicked(object sender, EventArgs e)
        {
             using(var form = new MakeTransactionForm(_currentUser))
            {
                form.ShowDialog();
            }
        }
    }
}
