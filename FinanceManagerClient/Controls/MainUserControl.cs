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
    public partial class MainUserControl : UserControl, ISettingsView
    {
        public event EventHandler Initialize;
        public event EventHandler<Args.DateRangeEventArgs> TimePeriodChanged;

        private readonly MainSettingsUserControlPresenter _presenter;

        public MainUserControl()
        {
            InitializeComponent();

            _presenter = new MainSettingsUserControlPresenter(this);

            InvokeInitialize(EventArgs.Empty);
        }

        private void InvokeInitialize(EventArgs args)
        {
            Initialize?.Invoke(this, args);
            SetNamesForButtons();
        }

        private void SetNamesForButtons()
        {
            var strings = _presenter.GetStringsForButtons();
            CurrentYearButton.Text = strings[0];
            NextYearButton.Text = strings[1];
        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
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
