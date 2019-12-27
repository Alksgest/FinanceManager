using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinanceManagerClient.Views;
using FinanceManagerClient.Presenters;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Controls
{
    public partial class ContributionToGluUserControl : UserControl, IGridView
    {
        public event EventHandler Initialize;
        public event EventHandler RefreshDataSoruceOnFocus;

        public object TransactionsDataSource { get; set; }

        private readonly ContributionToGluPresenter _presenter;

        private readonly Form _parent;

        public ContributionToGluUserControl(Form parent)
        {
            InitializeComponent();

            InvokeInitialize(EventArgs.Empty);

            _presenter = new ContributionToGluPresenter(this);
            _presenter.DataSourceUpdated += OnDataSourceUpdated;

            _parent = parent;

            if (_parent != null)
            {
                var mainForm = (_parent as MainForm);
                mainForm.TabIndexChanged += MainFormTabIndexChanged;
            }

            InitDataGridView();

            this.MouseClick += ContributionToGluUserControlMouseClick;
        }

        private void ContributionToGluUserControlMouseClick(object sender, MouseEventArgs e)
        {
            ContributionDataGridView.ClearSelection();
        }

        private void InitDataGridView()
        {
            ContributionDataGridView.AutoGenerateColumns = false;
            ContributionDataGridView.DataError += ContributionDataGridViewDataError;
            ContributionDataGridView.AllowUserToAddRows = false;
            ContributionDataGridView.RowHeadersVisible = false;

            ContributionDataGridView.AllowUserToResizeRows = false;
            ContributionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MainFormTabIndexChanged(object sender, EventArgs e)
        {
            RefreshDataSoruceOnFocus?.Invoke(sender, e);
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            GenerateTable();
        }

        private void GenerateTable()
        {
            if (TransactionsDataSource != null)
            {
                ContributionDataGridView.Columns.Clear();

                DataTable dt = InitDataTable();

                InitColumns();
                AddItemsToDataTable(dt);

                ContributionDataGridView.DataSource = dt;

                ChangeEditMode(true);
            }
        }

        private void AddItemsToDataTable(DataTable dt)
        {
            var trs = TransactionsDataSource as IEnumerable<Transaction>;

            foreach (var tr in trs)
            {
                var row = dt.NewRow();
                row.SetField(0, tr.TransactionOwner.ToString());
                row.SetField(1, tr.Amount);
                row.SetField(2, tr.Currency);
                row.SetField(3, tr.Date);
                row.SetField(4, tr.Comment);
                dt.Rows.Add(row);
            }
        }

        private static DataTable InitDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TransactionOwner", typeof(String));
            dt.Columns.Add("Amount", typeof(Decimal));
            dt.Columns.Add("Currency", typeof(Currency));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Comment", typeof(String));
            return dt;
        }

        private void InitColumns()
        {
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Name";
            name.DataPropertyName = "TransactionOwner";

            DataGridViewTextBoxColumn amount = new DataGridViewTextBoxColumn();
            amount.HeaderText = "Amount";
            amount.DataPropertyName = "Amount";

            DataGridViewComboBoxColumn currency = new DataGridViewComboBoxColumn();
            var currensies = Enum.GetValues(typeof(Currency));
            currency.DataSource = currensies;
            currency.HeaderText = "Currency";
            currency.DataPropertyName = "Currency";
            currency.SortMode = DataGridViewColumnSortMode.Automatic;

            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.HeaderText = "Date";
            date.DataPropertyName = "Date";

            DataGridViewTextBoxColumn comment = new DataGridViewTextBoxColumn();
            comment.HeaderText = "Comment";
            comment.DataPropertyName = "Comment";

            ContributionDataGridView.Columns.AddRange(name, amount, currency, date, comment);
        }

        private void ContributionDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Context.ToString());
        }

        private void InvokeInitialize(EventArgs args) => Initialize?.Invoke(this, args);

        private void EditCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ChangeEditMode(!EditCheckBox.Checked);
        }

        private void ChangeEditMode(bool isReadOnly)
        {
            foreach (DataGridViewColumn c in ContributionDataGridView.Columns)
            {
                c.ReadOnly = isReadOnly;
            }
        }

    }
}
