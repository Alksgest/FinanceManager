using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManager.Models;
using FinanceManager.Repositories;

namespace FinanceManager.Managers
{
    public class IncomeTransactionManager : ITransactionManager
    {
        private readonly List<Transaction>_transactions = new List<Transaction>();
        private readonly IRepository<Transaction> _repository;

        public IncomeTransactionManager()
        {
            _repository = new TransactionsRepository();
            _transactions = _repository.GetObjects().Where(t => t.Type == TransactionType.Income).ToList();
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactions;
        }

        public IEnumerable<Transaction> GetTransactions(DateTime from, DateTime to)
        {
            return _transactions.Where(tr =>
            {
                return tr.Date >= from && tr.Date <= to
;
            });
        }

        public void RemoveTransaction(Transaction transaction)
        {
            _transactions.Remove(transaction);
        }
    }
}
