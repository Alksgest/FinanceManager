using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManager.Models;
using FinanceManager.Repositories;

namespace FinanceManager.Managers
{
    public class IncomeTransactionManager : ITransactionManager
    {
        private readonly IRepository<Transaction> _repository;

        public IncomeTransactionManager()
        {
            _repository = new TransactionsRepository();
        }

        public void AddTransaction(Transaction transaction)
        {
            _repository.AddObject(transaction);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _repository.GetObjects().Where(t => t.Type == TransactionType.Income);
        }

        public void RemoveTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
