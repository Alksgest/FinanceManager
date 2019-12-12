using System.Collections.Generic;

namespace FinanceManager.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetObjects();

        void AddObject(T obj);
        void UpdateObject(T obj);
    }

}
