using System;
using System.Windows.Forms;

using FinanceManagerSDK.Models;

using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

namespace FinanceManagerClient
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler Initialize;
        public event EventHandler MakeTransaction;
        public event EventHandler AddUser;
        public event EventHandler AddReason;

        public event EventHandler RefreshNeeded;

        private readonly Form _loginForm;

        private readonly MainPresenter _presenter;

        public MainForm(User user, ILoginView _view)
        {
            InitializeComponent();

            _loginForm = _view as Form;

            _presenter = new MainPresenter(this, user);

            InvokeInitialize(new EventArgs());

            FormClosed += OnMainFormFormClosed;

        }

        private void OnMainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this._loginForm.Close();
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

        private void MakeTransactionButtonClick(object sender, EventArgs e)
        {
            MakeTransaction?.Invoke(sender, e);
            RefreshNeeded?.Invoke(sender, e);
        }

        private void MakeTransactionToolStripMenuItemClick(object sender, EventArgs e)
        {
            MakeTransaction?.Invoke(sender, e);
            RefreshNeeded?.Invoke(sender, e);
        }

        private void AddUserToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddUser?.Invoke(sender, e);
            RefreshNeeded?.Invoke(sender, e);
        }

        private void AddTransactionReasonToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddReason?.Invoke(sender, e);
            RefreshNeeded?.Invoke(sender, e);
        }
    }
}
