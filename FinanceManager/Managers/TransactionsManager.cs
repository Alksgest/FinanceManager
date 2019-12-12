using System;
using System.Collections.Generic;
using System.Text;

using FinanceManager.Models;
using FinanceManager.Util;

namespace FinanceManager.Managers
{
    class TransactionsManager
    {
        private readonly ITransactionManager _incomeTransactionManager;
        private readonly ITransactionManager _outcomeTransactionManager;

        public event Action<TransactionEventArgs> TransactionStarted;
        public event Action<TransactionEventArgs> TransactionDone; // args should be changed

        private readonly IRepository _repository;

        public TransactionsManager()
        {
            _incomeTransactionManager = new IncomeTransactionManager();
            _outcomeTransactionManager = new OutcomeTransactionManager();

            _repository = new Repository();
        }

        public TransactionsManager(ITransactionManager itm, ITransactionManager otm)
        {
            _incomeTransactionManager = itm;
            _outcomeTransactionManager = otm;

            _repository = new Repository();
        }

        public void MakeTransaction(Transaction transaction)
        {
            TransactionStarted?.Invoke(new TransactionEventArgs(transaction));

            ProcessTransaction(transaction);

            TransactionDone?.Invoke(new TransactionEventArgs(transaction));
        }

        private void ProcessTransaction(Transaction transaction)
        {
            switch (transaction.Type)
            {
                case TransactionType.Income:
                    _incomeTransactionManager.AddTransaction(transaction);
                    break;
                case TransactionType.Outcome:
                    _outcomeTransactionManager.AddTransaction(transaction);
                    break;
                default:
                    break;
            }
        }

        public void SaveTransactions()
        {
            // should save transactions to local storage
        }

        public void LoadTransactions()
        {
            // should load transactions from local storage
        }

    }
}
