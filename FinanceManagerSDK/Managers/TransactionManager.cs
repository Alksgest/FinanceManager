using System;
using System.Linq;
using System.Collections.Generic;

using FinanceManagerSDK.Models;
using FinanceManagerSDK.Repositories;

namespace FinanceManagerSDK.Managers
{
    public class TransactionManager : ITransactionManager
    {

        private readonly ITransactionRepository _repo;

        public event Action<TransactionEventArgs> TransactionStarted;
        public event Action<TransactionEventArgs> TransactionDone; 


        public TransactionManager()
        {
            _repo = new TransactionRepository();
        }

        public DateTime GetFirstTransactionTime()
        {
            return GetAllTransactions().Min(tr => tr.Date).GetValueOrDefault();
        }
        public DateTime GetLastTransactionTime()
        {
            return GetAllTransactions().Max(tr => tr.Date).GetValueOrDefault();
        }

        private IEnumerable<Transaction> GetIncomeTransactions()
        {
            return _repo.GetTransactions().Where(tr => tr.Type == TransactionType.Income);
        }

        private IEnumerable<Transaction> GetOutcomeTransactions()
        {
            return _repo.GetTransactions().Where(tr => tr.Type == TransactionType.Outcome);
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

        public void UpdateTransactions(IEnumerable<Transaction> trs)
        {
            foreach(var tr in trs)
            {
                _repo.UpdateTransaction(tr);
            }
        }

        private void ProcessTransaction(Transaction transaction)
        {
            _repo.AddTransaction(transaction);
        }


    }
}
