using System;

using FinanceManagerClient.Args;

namespace FinanceManagerClient.Views
{

    public interface ILoginView : IView
    {
        event EventHandler<LoginEventArgs> Login;
    }
}
