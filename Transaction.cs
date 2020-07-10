using System;

namespace supportbank
{

    public class Transaction
    {
        public DateTime date;
        public string to;
        public string from;

        public string narrative;
        public decimal amount;

        public Transaction(DateTime date,string to,string from,string narrative, decimal amount)
        {
           this.date = date; 
           this.to = to;
           this.from = from;
           this.narrative = narrative;
           this.amount = amount;
        }
     
    }
        
        
}
