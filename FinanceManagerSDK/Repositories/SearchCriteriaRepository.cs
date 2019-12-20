using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{
    public class SearchCriteriaRepository : AbstractRepository<SearchCriteria>, ISearchCriteriaRepository
    {
        public SearchCriteriaRepository() : base(@"db\criteria.db") { }
        public SearchCriteriaRepository(string dbString) : base(dbString) { }

        public IEnumerable<SearchCriteria> GetCriterias()
        {
            return this.GetObjects();
        }

        public void AddCriteria(SearchCriteria cr)
        {
            this.AddObject(cr);
        }

    }
}
