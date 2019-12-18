using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    public interface IMakeTransactionView : IView
    {
        event EventHandler<Transaction> TransactionStarted;
    }
}
