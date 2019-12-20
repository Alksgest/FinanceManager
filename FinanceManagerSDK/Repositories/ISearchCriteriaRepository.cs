using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Repositories
{
    public interface ISearchCriteriaRepository
    {
        void AddCriteria(SearchCriteria cr);
        IEnumerable<SearchCriteria> GetCriterias();
    }
}