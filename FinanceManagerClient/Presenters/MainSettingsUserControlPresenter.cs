using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Args;
using FinanceManagerClient.Util;
using FinanceManagerClient.Views;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Presenters
{
    class MainSettingsUserControlPresenter : Presenter<ISettingsView>
    {
        private const int _september = 9;

        public event EventHandler DataSourceUpdated;

        private readonly ITransactionManager _transactionManager;
        private readonly ISearchCriteriaManager _searchCriteriaManager;

        public IEnumerable<SearchCriteria> SearchCriteria => _searchCriteriaManager.GetCriterias();

        public MainSettingsUserControlPresenter(ISettingsView view) : base(view)
        {
            View.TimePeriodChanged += OnTimePeriodChanged;

            _transactionManager = new TransactionManager();
            _searchCriteriaManager = new SearchCriteriaManager();

            GlobalSettings.Instance.PropertyChanged += GlobalSettingsPropertyChanged;
        }

        private void GlobalSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var enumValue = 
                (GlobalSettingsProperties)Enum.Parse(typeof(GlobalSettingsProperties), e.PropertyName);

            switch (enumValue)
            {
                case GlobalSettingsProperties.CurrentDateRange:
                    break;
                case GlobalSettingsProperties.TransactionReasons:
                    break;
                case GlobalSettingsProperties.SearchCriteria:
                    View.CriteriaDataSource = GlobalSettings.Instance.SearchCriteria.ToArray();
                    break;
                case GlobalSettingsProperties.Users:
                    break;
                case GlobalSettingsProperties.Transactions:
                    break;
                default:
                    break;
            }

            DataSourceUpdated?.Invoke(sender, e);
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
                DateFrom = _transactionManager.GetFirstTransactionTime(),
                DateTo = _transactionManager.GetLastTransactionTime()
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
            GlobalSettings.Instance.CurrentDateRange = Tuple.Create(e.DateFrom, e.DateTo);
        }
    }
}
