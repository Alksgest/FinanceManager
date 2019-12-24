using System;
using System.Windows.Forms;

using FinanceManagerClient.Views;
using FinanceManagerClient.Presenters;

namespace FinanceManagerClient.Controls
{
    public partial class UsersGridControl : UserControl, IGridView
    {
        public event EventHandler Initialize;
        public event EventHandler RefreshDataSource;
        public event EventHandler RefreshDataSoruceOnFocus;

        public object TransactionsDataSource { get; set; }

        private readonly UsersGridControlPresenter _presenter;

        private readonly IMainView _parent;

        public UsersGridControl(IMainView parent)
        {
            InitializeComponent();

            _presenter = new UsersGridControlPresenter(this);

            InvokeInitialize(EventArgs.Empty);

            _presenter.DataSourceUpdated += OnDataSourceUpdated;
            _presenter.SetDataSoruce();

            _parent = parent;
            _parent.RefreshNeeded += OnRefreshNeeded;
        }

        private void OnRefreshNeeded(object sender, EventArgs e)
        {
            RefreshDataSource?.Invoke(sender, e);
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = TransactionsDataSource;
        }

        public void InvokeInitialize(EventArgs e) => Initialize?.Invoke(this, e);
    }
}
