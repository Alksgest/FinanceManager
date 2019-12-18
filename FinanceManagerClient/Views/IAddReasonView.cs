using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    interface IAddReasonView : IView
    {
        event EventHandler<TransactionReason> TransactionReasonAdd;
    }
}
