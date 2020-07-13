using System;
using System.Collections.Generic;
using System.Linq;
namespace supportbank
{
    
    class Program
    {
        static void Main(string[] args)
        {
           var transactions = CSVreader.ReadTransactionsFromfile();
           Console.WriteLine(transactions);

           var accounts = GetAccounts(transactions);

           Console.WriteLine(accounts);

        }

        static List<Account> GetAccounts(List<Transaction> transactions)
        {
          var names = getNames(transactions); 
          var allAccounts = new List<Account>();

          foreach(var currentName in names)
          {  
              var currentAccount = new Account(currentName);
              allAccounts.Add(currentAccount);
          }

          return allAccounts;
        }

        static HashSet<string> getNames(List<Transaction> transactions)
        {
            var allNames = new HashSet<string>();

            foreach(var currentTransaction in transactions)
            {
                allNames.Add(currentTransaction.to);
                allNames.Add(currentTransaction.from);
            }

            return allNames;
        }

        static void GetTotalAmount()
        {
            var totalamounts  new 

        }
    }

}
