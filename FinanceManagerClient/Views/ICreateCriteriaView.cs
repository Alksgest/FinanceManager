using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerSDK.Models;

namespace FinanceManagerClient.Views
{
    interface ICreateCriteriaView : IView
    {
        event EventHandler<SearchCriteria> CreateCriteria;
    }
}
