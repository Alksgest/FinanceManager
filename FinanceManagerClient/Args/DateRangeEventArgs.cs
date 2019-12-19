using System;

namespace FinanceManagerClient.Args
{
    public class DateRangeEventArgs : EventArgs
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
