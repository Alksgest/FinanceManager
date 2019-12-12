using FinanceManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManagerClient.Views
{
    public interface IMakeTransactionView : IView
    {
        event Action<Transaction> TransactionStarted;
    }
}
