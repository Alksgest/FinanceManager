using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManagerClient.Views
{
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler Load;
    }
}
