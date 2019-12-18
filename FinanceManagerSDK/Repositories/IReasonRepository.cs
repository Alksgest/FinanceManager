using FinanceManagerSDK.Models;
using System.Collections.Generic;

namespace FinanceManagerSDK.Repositories
{
    public interface IReasonRepository
    {
        void AddReason(TransactionReason tr);
        IEnumerable<TransactionReason> GetReasons();
        void UpdateReason(TransactionReason tr);
    }
}