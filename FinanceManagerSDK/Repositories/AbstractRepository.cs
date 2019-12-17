﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using LiteDB;

namespace FinanceManagerSDK.Repositories
{
    public abstract class AbstractRepository<T>
    {
        private readonly String _dbString;
        private readonly LiteDatabase _db;

        public AbstractRepository(String dbString)
        {
            _dbString = dbString;
            _db = new LiteDatabase(_dbString);

            CreateSubFolder();
        }

        private void CreateSubFolder()
        {
            var splited = _dbString.Split('\\');
            var folder = splited.Length > 1 ? String.Join("", splited.Take(splited.Length - 1)) : "";

            var fullPath = Directory.GetCurrentDirectory() + @"\" + folder;

            if(!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
        }

        protected IEnumerable<T> GetObjects()
        {
            return _db.GetCollection<T>().FindAll();
        }

        protected void AddObject(T obj)
        {
            var collection = _db.GetCollection<T>();

            var res = collection.Find(o => o.Equals(obj));

            if(res == null)
            {
                collection.Insert(obj);
            }

        }

        protected void UpdateObject(T obj)
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
