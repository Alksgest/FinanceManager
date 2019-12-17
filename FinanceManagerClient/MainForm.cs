using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Form _parentForm;

        private readonly MainPresenter _presenter;

        public MainForm(User user, ILoginView _view)
        {
            InitializeComponent();

            _parentForm = _view as Form;

            _presenter = new MainPresenter(this, user);

            InvokeInitialize(new EventArgs());

            FormClosed += OnMainFormFormClosed;

        }

        private void OnMainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this._parentForm.Close();
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

        private void MakeTransactionButtonClick(object sender, EventArgs e)
        {
            MakeTransaction?.Invoke(sender, e);
        }

        private void MakeTransactionToolStripMenuItemClick(object sender, EventArgs e)
        {
            MakeTransaction?.Invoke(sender, e);
        }

        private void AddUserToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddUser?.Invoke(sender, e);
        }
    }
}
