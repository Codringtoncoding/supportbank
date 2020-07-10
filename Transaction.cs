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

        public Transaction(DateTime date)
        {
           this.date = date; 
        }
    }
        
        
}
