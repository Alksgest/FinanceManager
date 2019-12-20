using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerSDK.Managers
{
    public class TransactionReasonManager : ITransactionReasonManager
    {

        private readonly IReasonRepository _repo;

        public TransactionReasonManager()
        {
            _repo = new ReasonRepository();
        }

        public IEnumerable<TransactionReason> GetReasons()
        {
            return _repo.GetReasons();
        }

        public void AddReason(TransactionReason r)
        {
            _repo.AddReason(r);
        }
    }
}
