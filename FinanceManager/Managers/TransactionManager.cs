using System;

using FinanceManager.Models;

namespace FinanceManager.Managers
{
    class TransactionManager
    {
        private readonly ITransactionManager _incomeTransactionManager;
        private readonly ITransactionManager _outcomeTransactionManager;

        public event Action<TransactionEventArgs> TransactionStarted;
        public event Action<TransactionEventArgs> TransactionDone; // args should be changed


        public TransactionManager()
        {
            _incomeTransactionManager = new IncomeTransactionManager();
            _outcomeTransactionManager = new OutcomeTransactionManager();

        }

        public TransactionManager(ITransactionManager itm, ITransactionManager otm)
        {
            _incomeTransactionManager = itm;
            _outcomeTransactionManager = otm;
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
