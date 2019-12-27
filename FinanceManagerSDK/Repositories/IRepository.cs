using System.Collections.Generic;

namespace FinanceManagerSDK.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetObjects();

        void AddObject(T obj);
        void RemoveObject(T obj);
        void UpdateObject(T obj);
    }

}
