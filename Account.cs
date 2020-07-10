using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace supportbank
{
    
    public class Account
    {
        public string Name;

        public List<Transaction> Owed;

        public List<Transaction> Owe;

        public Account(string name)
        {
            Name = name;
            Owed = new List<Transaction>();
            Owe = new List<Transaction>();

        }
        public decimal GetTotalAmount()
        {
            var totalOwed = new Decimal(0);
            foreach(var currentOwedTransaction in Owed)
            {
                totalOwed = totalOwed + currentOwedTransaction.amount;
            }
            foreach(var currentOweTransaction in Owe)
            {
                totalOwed = totalOwed - currentOweTransaction.amount;
            }

            return totalOwed;
            
            }
    }

}
