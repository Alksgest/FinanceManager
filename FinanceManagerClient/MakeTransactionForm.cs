using System;
using System.Linq;
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

        public void InvokeInitialize(EventArgs e)
        {
            Initialize?.Invoke(this, e);
            InitControls();
        }

        private void OnMakeTransactionButtonClick(object sender, EventArgs e)
        {
            if (ValidateModel())
            {
                var transaction = CreateTransaction();

                TransactionStarted?.Invoke(transaction);
            }
        }

        private bool ValidateModel()
        {
            bool isOwnerValid = ValidateComboBox(TransactionOwnerComboBox, "Select transaction owner.");
            bool isCurrencyValid = ValidateComboBox(CurrencyComboBox, "Select currency.");
            bool isReasonValid = ValidateComboBox(ReasonComboBox, "Select transaction reason.");
            bool isTypeValid = ValidateComboBox(TypeComboBox, "Select transaction type.");

            return isOwnerValid && isCurrencyValid && isReasonValid && isTypeValid;
        }

    
        private bool ValidateComboBox(ComboBox cb, string message)
        {
            bool isValid = true;
            if (cb.SelectedIndex <= 0)
            {
                isValid = false;
                ErrorProvider.SetError(cb, message);
            }
            else
            {
                ErrorProvider.SetError(cb, "");
            }

            return isValid;
        }

        private void OnResetButtonClick(object sender, EventArgs e) => ResetForm();

        private Transaction CreateTransaction()
        {
            var owner = TransactionOwnerComboBox.SelectedItem as User;
            var currency = (Currency)CurrencyComboBox.SelectedItem;
            var reason = ReasonComboBox.SelectedItem as TransactionReason;
            var type = (TransactionType)TypeComboBox.SelectedItem;

            Transaction tr = new Transaction
            {
                Amount = AmountNumericUpDown.Value,
                TransactionOwner = owner,
                Comment = CommentTextBox.Text,
                Currency = currency,
                Date = DateTimePicker.Value,
                Reason = reason,
                Type = type,
            };

            return tr;
        }

        private void ResetForm()
        {
            CommentTextBox.Clear();
            TypeComboBox.SelectedIndex = 0;
            ReasonComboBox.SelectedIndex = 0;
            CurrencyComboBox.SelectedIndex = 0;
            DateTimePicker.Value = DateTime.Now;
            TransactionOwnerComboBox.SelectedIndex = 0;
            AmountNumericUpDown.Value = AmountNumericUpDown.Minimum;

            ErrorProvider.SetError(TypeComboBox, "");
            ErrorProvider.SetError(ReasonComboBox, "");
            ErrorProvider.SetError(CurrencyComboBox, "");
            ErrorProvider.SetError(TransactionOwnerComboBox, "");
        }

        private void InitControls()
        {
            TransactionOwnerComboBox.Items.Add("");
            TransactionOwnerComboBox.Items.AddRange(_presenter.Users.ToArray());

            object[] currencies = { "", Currency.UAH, Currency.USD, Currency.EUR };
            CurrencyComboBox.Items.AddRange(currencies);

            ReasonComboBox.Items.Add("");
            ReasonComboBox.Items.AddRange(_presenter.Reasons.ToArray());

            object[] transactionTypes = { "", TransactionType.Income, TransactionType.Outcome };
            TypeComboBox.Items.AddRange(transactionTypes);
        }
    }
}
