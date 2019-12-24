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
        }

        private void MainFormTabIndexChanged(object sender, EventArgs e)
        {
            RefreshDataSoruceOnFocus?.Invoke(sender, e);
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            ContributionDataGridView.DataSource = TransactionsDataSource;
            ContributionDataGridView.Refresh();
        }

        private void InvokeInitialize(EventArgs args) => Initialize?.Invoke(this, args);

    }
}
