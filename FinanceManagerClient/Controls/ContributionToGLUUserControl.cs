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
        public event EventHandler RefreshDataSource;

        public object DataSource { get; set; }

        private readonly IMainView _parent;

        private readonly ContributionToGluPresenter _presenter;

        public ContributionToGluUserControl(Form view)
        {
            InitializeComponent();

            InvokeInitialize(EventArgs.Empty);

            _presenter = new ContributionToGluPresenter(this);
            _presenter.DataSourceUpdated += OnDataSourceUpdated;
            _presenter.SetDataSoruce();

            _parent = view as IMainView;

            if (_parent != null)
                _parent.RefreshNeeded += OnRefreshNeeded;
        }

        private void OnRefreshNeeded(object sender, EventArgs e)
        {
            RefreshDataSource?.Invoke(sender, e);
        }
        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            ContributionDataGridView.DataSource = DataSource;
        }

        public ContributionToGluUserControl()
        {
            InitializeComponent();

            InvokeInitialize(EventArgs.Empty);
        }

        private void InvokeInitialize(EventArgs args) => Initialize?.Invoke(this, args);

    }
}
