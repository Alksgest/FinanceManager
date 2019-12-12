using System;
using System.Collections.Generic;

using FinanceManager.Models;

namespace FinanceManager.Managers
{
    public class OutcomeTransactionManager : ITransactionManager
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();

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
            throw new NotImplementedException();
        }

        public void RemoveTransaction(Transaction transaction)
        {
            _transactions.Remove(transaction);
        }
    }
}
