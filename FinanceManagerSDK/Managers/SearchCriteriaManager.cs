using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerSDK.Managers
{
    public class SearchCriteriaManager : ISearchCriteriaManager
    {
        private readonly ISearchCriteriaRepository _repo;

        public SearchCriteriaManager()
        {
            _repo = new SearchCriteriaRepository();
        }

        public void AddCriteria(SearchCriteria criteria) => _repo.AddCriteria(criteria);

        public IEnumerable<SearchCriteria> GetCriterias() => _repo.GetCriterias();
    }
}
