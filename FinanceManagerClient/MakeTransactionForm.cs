using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceManager.Models;
using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

namespace FinanceManagerClient
{
    public partial class MakeTransactionForm : Form, IMakeTransactionView
    {
        public event Action<Transaction> TransactionStarted;
        public event EventHandler Initialize;

        private readonly MakeTransactionPresenter _presenter;

        public MakeTransactionForm()
        {
            InitializeComponent();

            _presenter = new MakeTransactionPresenter(this);

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
                Brother = BrotherComboBox.SelectedItem as Brother,
                Comment = CommentTextBox.Text,
                Currency = Currency.,
                Date = DateTimePicker.Value,
                Reason = ReasonComboBox.SelectedItem as TransactionReason,
                Type =
            };
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
