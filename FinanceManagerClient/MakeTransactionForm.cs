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
    public partial class MakeTransactionForm : Form, IMakeTransactionView
    {
        public event Action<Transaction> TransactionStarted;
        public event EventHandler Initialize;

        private readonly MakeTransactionPresenter _presenter;

        public MakeTransactionForm(User currentUser)
        {
            InitializeComponent();

            _presenter = new MakeTransactionPresenter(this, currentUser);

            InvokeInitialize(new EventArgs());
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);

        private void MakeTrButton_Click(object sender, EventArgs e)
        {
            TransactionStarted?.Invoke(null);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private Transaction CreateTransaction()
        {
            Transaction tr = new Transaction
            {
                Amount = AmountNumericUpDown.Value,
                TransactionOwner = BrotherComboBox.SelectedItem as User,
                Comment = CommentTextBox.Text,
                Currency = Currency.UAH, //mock
                Date = DateTimePicker.Value,
                Reason = ReasonComboBox.SelectedItem as TransactionReason,
                Type = TransactionType.Income // mock
            };

            return tr;
        }

        private void ResetForm()
        {
            AmountNumericUpDown.Value = 0;
            BrotherComboBox.SelectedIndex = 0;
            CommentTextBox.Clear();
            CurrencyComboBox.SelectedIndex = 0;
            DateTimePicker.Value = DateTime.Now;
            ReasonComboBox.SelectedIndex = 0;
            TypeComboBox.SelectedIndex = 0;
        }
    }
}
