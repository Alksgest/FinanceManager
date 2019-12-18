using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    public interface IMainView : IView
    {
        event EventHandler MakeTransaction;
        event EventHandler AddReason;
        event EventHandler AddUser;

        event EventHandler RefreshNeeded;
    }
}
