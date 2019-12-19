using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinanceManagerClient.Util
{
    internal class GlobalSettings : INotifyPropertyChanged
    {
        private static GlobalSettings _instance = null;

        public event PropertyChangedEventHandler PropertyChanged;

        private Tuple<DateTime, DateTime> _currentDateRange;

        public static GlobalSettings Instance => _instance ?? (_instance = new GlobalSettings());

        private GlobalSettings() { }

        public Tuple<DateTime, DateTime> CurrentDateRange
        {
            get => _currentDateRange;
            set
            {
                _currentDateRange = value;
                NotifyPropertyChanged("CurrentDateRange");
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
