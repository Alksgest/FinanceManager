using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Repositories
{
    public interface IReasonRepository
    {
        void AddReason(TransactionReason r);
        IEnumerable<TransactionReason> GetReasons();
        void UpdateReason(TransactionReason r);
        void RemoveReason(TransactionReason r);
    }
}