﻿using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerSDK.Managers
{
    public class IncomeTransactionManager : ITransactionManager
    {
        private readonly ITransactionRepository _repository;

        public IncomeTransactionManager()
        {
            _repository = new TransactionRepository();
        }

        public void AddTransaction(Transaction transaction)
        {
            _repository.AddTransaction(transaction);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _repository.GetTransactions().Where(t => t.Type == TransactionType.Income);
        }

        public void RemoveTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
