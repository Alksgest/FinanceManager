using System;

namespace FinanceManagerClient.Views
{
    internal interface IUsersView : IView
    {
        object DataSource { get; set; }
        event EventHandler Refresh;
    }
}