using System;
using System.Collections.Generic;
using LiteDB;

namespace FinanceManager.Repositories
{
    public abstract class AbstractRepository<T> : IRepository<T>
    {
        private readonly String _dbString;
        private readonly LiteDatabase _db;

        public AbstractRepository(String dbString)
        {
            _dbString = dbString;
            _db = new LiteDatabase(_dbString);
        }

        public IEnumerable<T> GetObjects()
        {
            return _db.GetCollection<T>().FindAll();
        }

        public void AddObject(T obj)
        {
            var collection = _db.GetCollection<T>();

            var res = collection.Find(o => o.Equals(obj));

            if(res == null)
            {
                collection.Insert(obj);
            }

        }

        public void UpdateObject(T obj)
        {
            var collection = _db.GetCollection<T>();

            var res = collection.Find(o => o.Equals(obj));

            if (res != null)
            {
                collection.Update(obj);
            }
        }
    }

}
