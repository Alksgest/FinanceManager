using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManagerSDK.Models;

namespace FinanceManagerSDK.Managers
{
    public class TransactionManager : ITransactionManager
    {
        private readonly ITransactionProvider _incomeTransactionProvider;
        private readonly ITransactionProvider _outcomeTransactionProvider;

        public event Action<TransactionEventArgs> TransactionStarted;
        public event Action<TransactionEventArgs> TransactionDone; 


        public TransactionManager()
        {
            _incomeTransactionProvider = new IncomeTransactionProvider();
            _outcomeTransactionProvider = new OutcomeTransactionProvider();
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
            _incomeTransactionProvider = itm;
            _outcomeTransactionProvider = otm;
        }

        private IEnumerable<Transaction> GetIncomeTransactions()
        {
            return _incomeTransactionProvider.GetTransactions();
        }

        private IEnumerable<Transaction> GetOutcomeTransactions()
        {
            return _outcomeTransactionProvider.GetTransactions();
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            var income = GetIncomeTransactions();
            var outcome = GetOutcomeTransactions();
            return income.Concat(outcome);
        }

        public IEnumerable<Transaction> GetTransactions(SearchCriteria criteria)
        {
            var c = criteria;

            IEnumerable<Transaction> trs;
            switch (c.TransactionType)
            {
                case TransactionType.Income:
                    trs = GetIncomeTransactions();
                    break;
                case TransactionType.Outcome:
                    trs = GetOutcomeTransactions();
                    break;
                default:
                    {
                        var income = GetIncomeTransactions();
                        var outcome = GetOutcomeTransactions();
                        trs = income.Concat(outcome);
                    }
                    break;
            }

            var res = trs
                .Where(t => c.Amount != null ? t.Amount == c.Amount : true)
                .Where(t => c.Currency != null ? t.Currency == c.Currency : true)
                .Where(t => c.DateFrom != null ? t.Date > c.DateFrom : true)
                .Where(t => c.DateTo != null ? t.Date < c.DateTo : true)
                .Where(t => c.Reason != null ? t.Reason.Equals(c.Reason) : true)
                .Where(t => c.TransactionOwner != null ? t.TransactionOwner.Equals(c.TransactionOwner) : true);

            return res;
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
                    _incomeTransactionProvider.AddTransaction(transaction);
                    break;
                case TransactionType.Outcome:
                    _outcomeTransactionProvider.AddTransaction(transaction);
                    break;
                default:
                    break;
            }
        }


    }
}
