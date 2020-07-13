using System;
using System.Collections.Generic;

namespace supportbank
{
        class Program
    {
        static void Main(string[] args)
        {
           var transactions = CSVreader.ReadTransactionsFromfile();
           Console.WriteLine(transactions);


           var accounts = Bank.GetAccounts(transactions);

           Console.WriteLine(accounts);

        }     
     
    }

}
