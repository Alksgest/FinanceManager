using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManager.Models;
using FinanceManager.Repositories;

namespace FinanceManager.Managers
{
    public class OutcomeTransactionManager : ITransactionManager
    {
        private readonly List<Transaction> _transactions;
        private readonly IRepository<Transaction> _repository;

        public OutcomeTransactionManager()
        {
            _repository = new TransactionsRepository();
            _transactions = _repository.GetObjects().Where(t => t.Type == TransactionType.Outcome).ToList();
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            _repository.AddObject(transaction);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactions;
        }

        public IEnumerable<Transaction> GetTransactions(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
