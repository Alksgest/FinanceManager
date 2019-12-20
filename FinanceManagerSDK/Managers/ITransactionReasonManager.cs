using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Managers
{
    public interface ITransactionReasonManager
    {
        void AddReason(TransactionReason r);
        IEnumerable<TransactionReason> GetReasons();
    }
}