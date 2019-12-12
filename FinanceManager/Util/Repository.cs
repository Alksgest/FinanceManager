using FinanceManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Util
{
    public interface IRepository
    {
        IEnumerable<Transaction> GetTransactions();
        IEnumerable<Brother> GetBrothers();
        IEnumerable<String> GetAllowedReasons();
    }

    public class Repository
    {
    }
}
