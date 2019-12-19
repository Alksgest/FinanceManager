using System;

namespace FinanceManagerClient.Views
{
    internal interface IGridView : IView
    {
        object DataSource { get; set; }
        event EventHandler RefreshDataSource;
    }
}