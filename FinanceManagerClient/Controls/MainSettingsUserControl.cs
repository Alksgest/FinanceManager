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
    public partial class MainSettingsUserControl : UserControl, ISettingsView
    {
        public event EventHandler Initialize;
        public event EventHandler<Args.DateRangeEventArgs> TimePeriodChanged;
        public object[] CriteriaDataSource { get; set; }

        private readonly MainSettingsUserControlPresenter _presenter;

        public MainSettingsUserControl()
        {
            InitializeComponent();

            _presenter = new MainSettingsUserControlPresenter(this);
            _presenter.DataSourceUpdated += OnDataSourceUpdated;


            InvokeInitialize(EventArgs.Empty);
        }

        private void OnDataSourceUpdated(object sender, EventArgs e)
        {
            this.CriteriaComboBox.Items.Clear();
            this.CriteriaComboBox.Items.Add("");
            this.CriteriaComboBox.Items.AddRange(CriteriaDataSource);
        }

        private void InvokeInitialize(EventArgs args)
        {
            Initialize?.Invoke(this, args);
            SetNamesForButtons();
            InitCriteriaComboBox();
        }

        private void InitCriteriaComboBox()
        {
            CriteriaComboBox.Items.Add("");
            CriteriaComboBox.Items.AddRange(_presenter.SearchCriteria.ToArray());
        }

        private void SetNamesForButtons()
        {
            var strings = _presenter.GetStringsForButtons();
            CurrentYearButton.Text = strings[0];
            NextYearButton.Text = strings[1];
        }

        private void CurrentYearButtonClick(object sender, EventArgs e)
        {
            TimePeriodChanged?.Invoke(sender, _presenter.GetCurrentYearRange());
        }

        private void NextYearButtonClick(object sender, EventArgs e)
        {
            TimePeriodChanged?.Invoke(sender, _presenter.GetCurrentYearRange());
        }

        private void TotalButtonClick(object sender, EventArgs e)
        {
            TimePeriodChanged?.Invoke(sender, _presenter.GetTotalDateRange());
        }
    }
}
