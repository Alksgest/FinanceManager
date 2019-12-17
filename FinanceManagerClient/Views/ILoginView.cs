using System;

using FinanceManagerClient.Args;

namespace FinanceManagerClient.Views
{

    interface ILoginView : IView
    {
        event EventHandler<LoginEventArgs> Login;
    }
}
