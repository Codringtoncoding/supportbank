using System;
using System.Collections.Generic;

namespace supportbank
{
    
    public class Account
    {
        public string Name;

        public List<Transaction> incomingTransactions;

        public List<Transaction> outgoingTransations;

        public Account(string name)
        {
            this.Name = name;
            incomingTransactions = new List<Transaction>();
            outgoingTransations = new List<Transaction>();
        }

        public decimal GetTotalIncoming()
        {
            var total = new decimal(0);

            foreach (var Transaction in incomingTransactions)
            {
                total = total + Transaction.amount;
            }

            return total;
        }

        public decimal GetTotalOutgoing()
        {
            var total = new decimal(0);

            foreach (var Transaction in outgoingTransations)
            {
                total = total + Transaction.amount;

            }
            return total;

        }

        
        public decimal GetTotalAmount()
        {
            return GetTotalOutgoing() - GetTotalIncoming();
            
        }


    }


}
