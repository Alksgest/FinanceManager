using System;

namespace FinanceManagerClient.Views
{
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler Load;
    }
}
