using System;
using System.Collections.Generic;
using System.Text;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Repositories
{

    public class ReasonRepository : AbstractRepository<TransactionReason>
    {
        public ReasonRepository() : base(@"db\allowedReasons.db") { }

        public ReasonRepository(string dbString) : base(dbString) { }

        public IEnumerable<TransactionReason> GetReasons()
        {
            return this.GetObjects();
        }

        public void AddReason(TransactionReason tr)
        {
            this.AddObject(tr);
        }

        public void UpdateReason(TransactionReason tr)
        {
            this.UpdateObject(tr);
        }

    }

}
