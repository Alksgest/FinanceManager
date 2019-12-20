using System;
using System.Linq;
using System.Windows.Forms;

using FinanceManagerSDK.Models;

using FinanceManagerClient.Presenters;
using FinanceManagerClient.Views;

namespace FinanceManagerClient
{
    public partial class CreateCriteriaForm : Form, ICreateCriteriaView
    {
        public event EventHandler<SearchCriteria> CreateCriteria;
        public event EventHandler Initialize;

        private readonly CreateCriteriaPresenter _presenter;

        public CreateCriteriaForm()
        {
            InitializeComponent();

            _presenter = new CreateCriteriaPresenter(this);

            InvokeInitialize(new EventArgs());
        }



        public void InvokeInitialize(EventArgs e)
        {
            Initialize?.Invoke(this, e);
            InitControls();
        }

        private void OnCreateCriteriaButtonClick(object sender, EventArgs e)
        {
            if (ValidateModel())
            {
                var criteria = CreateCriteriaMethod();

                CreateCriteria?.Invoke(sender, criteria);

                this.Close();
            }
        }

        private bool ValidateModel()
        {
            var isNameCorrect = ValidateName();

            return isNameCorrect;
        }

        private bool ValidateName()
        {
            var isCorrect = !String.IsNullOrEmpty(NameTextBox.Text.Trim());
            if(!isCorrect)
                ErrorProvider.SetError(NameTextBox, "Enter name of criteria.");
            else
                ErrorProvider.SetError(NameTextBox, "");

            return isCorrect;
        }

        private SearchCriteria CreateCriteriaMethod()
        {
            var name = NameTextBox.Text.Trim();
            var owner = TransactionOwnerComboBox.SelectedItem as User;
            Currency? c = null;
            Currency? currency = CurrencyComboBox.SelectedItem == null ? c 
                :(Currency)CurrencyComboBox.SelectedItem;
            var reason = ReasonComboBox.SelectedItem as TransactionReason;
            TransactionType? t = null;
            TransactionType? type = TypeComboBox.SelectedItem == null ? t 
                :(TransactionType)TypeComboBox.SelectedItem;
            //DateTime? dateFrom = DateFromTimePicker.Value == DateTime.Now ? null : DateFromTimePicker.Value;

            SearchCriteria criteria = new SearchCriteria
            {
                Name = name,             
                Amount = AmountNumericUpDown.Value,
                TransactionOwner = owner,
                Currency = currency,
                // DateFrom = dateFrom,
                // DateTo = dateTo
                Reason = reason,
                TransactionType = type,
            };

            return criteria;
        }

        private void InitControls()
        {
            TransactionOwnerComboBox.Items.Add("");
            TransactionOwnerComboBox.Items.AddRange(_presenter.Users.ToArray());

            ReasonComboBox.Items.Add("");
            ReasonComboBox.Items.AddRange(_presenter.Reasons.ToArray());

            object[] currencies = { "", Currency.UAH, Currency.USD, Currency.EUR };
            CurrencyComboBox.Items.AddRange(currencies);

            object[] transactionTypes = { "", TransactionType.Income, TransactionType.Outcome };
            TypeComboBox.Items.AddRange(transactionTypes);
        }
    }
}
