using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Args;
using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;

namespace FinanceManagerClient.Presenters
{
    class MainSettingsUserControlPresenter : Presenter<ISettingsView>
    {
        private const int _september = 9;

        private readonly ITransactionManager _manager;

        public MainSettingsUserControlPresenter(ISettingsView view) : base(view)
        {
            View.TimePeriodChanged += OnTimePeriodChanged;

            _manager = new TransactionManager();
        }

        public String[] GetStringsForButtons()
        {
            var now = DateTime.Now;
            String[] strings = new String[2];
            strings[0] = now.Month < _september ?
                $"{now.Year - 1 + 4000} | {now.Year + 4000}" :
                    $"{now.Year + 4000} | {now.Year + 1 + 4000}";

            strings[1] = now.Month < _september ?
                $"{now.Year + 4000} | {now.Year + 1 + 4000}" :
                    $"{now.Year + 1 + 4000} | {now.Year + 2 + 4000}";

            return strings;
        }

        public DateRangeEventArgs GetTotalDateRange()
        {
            return new DateRangeEventArgs
            {
                DateFrom = _manager.GetFirstTransactionTime(),
                DateTo = _manager.GetLastTransactionTime()
            };
        }

        public DateRangeEventArgs GetPreviousYearRange()
        {
            var now = DateTime.Now;

            DateTime from = now.Month < _september ?
                new DateTime(now.Year - 2, _september, 1) :
                    new DateTime(now.Year - 1, _september, 1);

            DateTime to = now.Month < _september ?
                new DateTime(now.Year - 1, _september, 1) :
                    new DateTime(now.Year, _september, 1);

            return new DateRangeEventArgs
            {
                DateFrom = from,
                DateTo = to
            };
        }

        public DateRangeEventArgs GetCurrentYearRange()
        {
            var now = DateTime.Now;

            DateTime from = now.Month < _september ?
                new DateTime(now.Year - 1, _september, 1) :
                    new DateTime(now.Year, _september, 1);

            DateTime to = now.Month < _september ?
                new DateTime(now.Year, _september, 1) :
                    new DateTime(now.Year + 1, _september, 1);

            return new DateRangeEventArgs
            {
                DateFrom = from,
                DateTo = to
            };
        }

        private void OnTimePeriodChanged(object sender, DateRangeEventArgs e)
        {
            var settings = GlobalSettings.Instance;
            settings.CurrentDateRange = Tuple.Create(e.DateFrom, e.DateTo);
        }
    }
}
