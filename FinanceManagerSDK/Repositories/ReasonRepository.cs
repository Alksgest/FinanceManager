using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{

    public class ReasonRepository : AbstractRepository<TransactionReason>, IReasonRepository
    {
        public ReasonRepository() : base(@"db\allowedReasons.db") { }

        public ReasonRepository(string dbString) : base(dbString) { }

        public IEnumerable<TransactionReason> GetReasons()
        {
            return this.GetObjects();
        }

        public void AddReason(TransactionReason r)
        {
            this.AddObject(r);
        }

        public void UpdateReason(TransactionReason r)
        {
            this.UpdateObject(r);
        }

        public void RemoveReason(TransactionReason r)
        {
            this.RemoveObject(r);
        }

    }

}
