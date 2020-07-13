using System;
using System.Collections.Generic;

namespace supportbank
{
        class Program
    {
        static void Main(string[] args)
        {
           var transactions = CSVreader.ReadTransactionsFromfile();
       


           var accounts = Bank.GetAccounts(transactions);
           
               foreach (var account in accounts)
               {
            
                 

               }

           var UpdatedAccounts = Bank.UpdatedAccounts(transactions, accounts);

           Console.WriteLine(UpdatedAccounts);
                

       

        }     
     
    }

}
