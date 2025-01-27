﻿using System;
using System.Windows.Forms;

using FinanceManagerClient.Args;
using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler Initialize;
        public event EventHandler<LoginEventArgs> Login;

        private readonly LoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);

            InvokeInitialize(new EventArgs());

            _presenter.LoginDone += OnLoginDone;
            _presenter.ClosingFormInvoked += OnClosingFormInvoked;
        }

        private void OnClosingFormInvoked(object sender, EventArgs e) => this.Close();

        public void InvokeInitialize(EventArgs e)
        {
            Initialize?.Invoke(this, e);
            InitControls();
        }

        private void OnLoginDone(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (ValidateModel())
            {
                var degree = (Degree)DegreeComboBox.SelectedItem;
                Login(this, new LoginEventArgs
                {
                    Degree = degree,
                    Lastname = NameTextBox.Text
                });
            }
        }

        private bool ValidateModel()
        {
            var isSurnameValid = ValidateSurname();
            var isDegreeValid = ValidateDegree();

            return isSurnameValid && isDegreeValid;
        }

        private bool ValidateSurname()
        {
            bool isValidated = true;
            if (NameTextBox.Text.Trim().Length == 0)
            {
                ErrorProvider.SetError(NameTextBox, "Enter lastname, please.");
                isValidated = false;
            }
            else
            {
                ErrorProvider.SetError(NameTextBox, "");
            }
            return isValidated;
        }

        private bool ValidateDegree()
        {
            bool isValidated = true;
            if(DegreeComboBox.SelectedIndex <= 0)
            {
                ErrorProvider.SetError(DegreeComboBox, "Select degree.");
                isValidated = false;
            }
            else
            {
                ErrorProvider.SetError(DegreeComboBox, "");
            }

            return isValidated;
        }
    
        private void InitControls()
        {
            object[] values = { "", Degree.First, Degree.Second, Degree.Third };
            DegreeComboBox.Items.AddRange(values);
        }
    }
}
