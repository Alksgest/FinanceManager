using System;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    interface ICreateUserView : IView
    {
        event EventHandler<User> UserCreation;
    }
}
