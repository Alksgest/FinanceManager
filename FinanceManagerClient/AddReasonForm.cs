using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient
{
    public partial class AddReasonForm : Form, IAddReasonView
    {
        public event EventHandler<TransactionReason> TransactionReasonAdd;
        public event EventHandler Initialize;

        private AddReasonPresenter _presenter;

        public AddReasonForm()
        {
            InitializeComponent();

            _presenter = new AddReasonPresenter(this);

            InvokeInitialize(new EventArgs());
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

        private void CreateButtonClick(object sender, EventArgs e)
        {
            var reason = CreateReason();
            TransactionReasonAdd?.Invoke(sender, reason);
        }

        private TransactionReason CreateReason()
        {
            TransactionReason r = new TransactionReason
            {
                ShortDesctiption = ShortDescriptionTextBox.Text,
                LongDesctiption = LongDescriptionTextBox.Text
            };

            return r;
        }
    }
}
