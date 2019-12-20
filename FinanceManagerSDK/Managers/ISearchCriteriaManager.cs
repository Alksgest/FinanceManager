using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Managers
{
    public interface ISearchCriteriaManager
    {
        void AddCriteria(SearchCriteria criteria);
        IEnumerable<SearchCriteria> GetCriterias();
    }
}