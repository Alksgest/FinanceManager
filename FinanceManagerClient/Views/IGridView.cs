using System;

namespace FinanceManagerClient.Views
{
    internal interface IGridView : IView
    {
        object TransactionsDataSource { get; set; }
        event EventHandler RefreshDataSoruceOnFocus;
    }
}