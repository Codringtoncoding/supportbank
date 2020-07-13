using System.Collections.Generic;

namespace supportbank
{
    public class Bank
    {
    public static List<Account> GetAccounts(List<Transaction> transactions)
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

        public static HashSet<string> getNames(List<Transaction> transactions)
        {
            var allNames = new HashSet<string>();

            foreach(var currentTransaction in transactions)
            {
                allNames.Add(currentTransaction.to);
                allNames.Add(currentTransaction.from);
            }

            return allNames;
        }

        public static List<Account> UpdatedAccounts(List<Transaction> transactions, List<Account> accounts)
        {
            foreach(var transaction in transactions)
            {
                var account = findAccount(transaction.from, accounts);
                account.outgoingTransactions.Add(transaction);
                

            }

            foreach(var transaction in transactions)
            {
                var account = findAccount(transaction.to, accounts);
                account.incomingTransactions.Add(transaction);
            }

            return accounts;
        }

        public static Account findAccount(string name, List<Account> accounts)
        {
            foreach(var account in accounts)
            {
            if (name == account.Name)
                {   
                
                    return account;
                
                }
            
            }

            return null;

        }
    
    
        
    }
}