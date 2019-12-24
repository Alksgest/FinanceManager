using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerClient.Args;

namespace FinanceManagerClient.Views
{

    public interface ISettingsView : IView
    {
        event EventHandler<DateRangeEventArgs> TimePeriodChanged;
        object[] CriteriaDataSource { get; set; }
    }
}
