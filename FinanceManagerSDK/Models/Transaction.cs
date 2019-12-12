﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Models
{
    [Serializable]
    public class Transaction
    {
        public int Id { get; set; }
        public Decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public Brother Brother { get; set; }
        public TransactionReason Reason { get; set; }
        public TransactionType Type { get; set; }
        public DateTime? Date { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return $"id = {Id}\n" +
                $"Amount = {Amount}\n" +
                    $"Currency = {Currency}\n" +
                        $"Comment = {Comment}\n" +
                            $"Reason = {Reason.Desctiption}\n";
        }
    }
}
