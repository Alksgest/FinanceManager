using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using FinanceManagerSDK.Managers;
using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Util
{

    internal class GlobalSettings : INotifyPropertyChanged
    {
        private static GlobalSettings _instance = null;
        public static GlobalSettings Instance => _instance ?? (_instance = new GlobalSettings());

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler OnTransactionAdded;

        private readonly ITransactionReasonManager _reasonManager;
        private readonly ISearchCriteriaManager _searchCriteriaManager;
        private readonly IUserManager _userManager;

        private Tuple<DateTime, DateTime> _currentDateRange;
        private IEnumerable<TransactionReason> _reasons;
        private IEnumerable<SearchCriteria> _criteria;
        private IEnumerable<User> _users;

        private GlobalSettings() 
        {
            _reasonManager = new TransactionReasonManager();
            _searchCriteriaManager = new SearchCriteriaManager();
            _userManager = new UserManager();

            _reasons = _reasonManager.GetReasons();
            _criteria = _searchCriteriaManager.GetCriterias();
            _users = _userManager.GetUsers();
        }

        public void TransactionAddedInvokation(object sender)
        {
            OnTransactionAdded?.Invoke(sender, EventArgs.Empty);
        }

        public Tuple<DateTime, DateTime> CurrentDateRange
        {
            get => _currentDateRange;
            set
            {
                _currentDateRange = value;
                NotifyPropertyChanged(GlobalSettingsProperties.CurrentDateRange.ToString());
            }
        }

        public IEnumerable<TransactionReason> TransactionReasons
        {
            get => _reasons;
            set
            {
                _reasons = value;
                NotifyPropertyChanged(GlobalSettingsProperties.TransactionReasons.ToString());
            }
        }

        public IEnumerable<SearchCriteria> SearchCriteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                NotifyPropertyChanged(GlobalSettingsProperties.SearchCriteria.ToString());
            }
        }

        public IEnumerable<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                NotifyPropertyChanged(GlobalSettingsProperties.Users.ToString());
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
