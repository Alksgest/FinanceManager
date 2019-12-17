using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    interface IMainView : IView
    {
        event EventHandler MakeTransaction;
        event EventHandler AddUser;
    }
}
