using System.Collections.Generic;

namespace FinanceManagerSDK.Repositories
{
    public interface ITransactionRepository<T>
    {
        IEnumerable<T> GetObjects();

        void AddObject(T obj);
        void UpdateObject(T obj);
    }

}
