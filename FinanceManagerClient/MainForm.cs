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
        public event EventHandler MakeTransactionClicked;

        private readonly MainPresenter _presenter;

        public MainForm(User user)
        {
            InitializeComponent();

            _presenter = new MainPresenter(this, user);

            InvokeInitialize(new EventArgs());
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

        private void MakeTransactionButtonClick(object sender, EventArgs e)
        {
            MakeTransactionClicked?.Invoke(sender, e);
        }
    }
}
