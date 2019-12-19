using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Managers
{
    public class TransactionManager : ITransactionManager
    {
        private readonly ITransactionProvider _incomeTransactionManager;
        private readonly ITransactionProvider _outcomeTransactionManager;

        public event Action<TransactionEventArgs> TransactionStarted;
        public event Action<TransactionEventArgs> TransactionDone; 


        public TransactionManager()
        {
            _incomeTransactionManager = new IncomeTransactionProvider();
            _outcomeTransactionManager = new OutcomeTransactionProvider();
        }

        public DateTime GetFirstTransactionTime()
        {
            return GetAllTransactions().Min(tr => tr.Date).GetValueOrDefault();
        }
        public DateTime GetLastTransactionTime()
        {
            return GetAllTransactions().Max(tr => tr.Date).GetValueOrDefault();
        }

        public TransactionManager(ITransactionProvider itm, ITransactionProvider otm)
        {
            _incomeTransactionManager = itm;
            _outcomeTransactionManager = otm;
        }

        public IEnumerable<Transaction> GetIncomeTransactions()
        {
            return _incomeTransactionManager.GetTransactions();
        }

        public IEnumerable<Transaction> GetOutcomeTransactions()
        {
            return _outcomeTransactionManager.GetTransactions();
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            var income = GetIncomeTransactions();
            var outcome = GetOutcomeTransactions();
            return income.Concat(outcome);
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
    }
}
