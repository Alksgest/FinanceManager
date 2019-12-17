using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    public interface IMakeTransactionView : IView
    {
        event Action<Transaction> TransactionStarted;
    }
}
