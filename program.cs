using System.Reflection;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace supportbank
{
        class Program
    {
        private static void ConfigureLogger()
        {
            var config = new LoggingConfiguration();
            var target = new FileTarget { FileName = @"SupportBank.log", Layout = @"${longdate}) -${logger} - ${logger}: ${message}"};
            config.AddTarget("File Logger", target);

            var consoleTarget = new ConsoleTarget { Layout =@"${longdate}) -${logger} - ${logger}: ${message}"};
            config.AddTarget("Console Logger", consoleTarget);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug,target));
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Error, consoleTarget));
            LogManager.Configuration = config;
        }
        static void Main(string[] args)
        {
           var transactions = CSVreader.ReadTransactionsFromfile;
       


           var accounts = Bank.GetAccounts(transactions);
           
               foreach (var account in accounts)
               {
            
                 

               }

           var UpdatedAccounts = Bank.UpdatedAccounts(transactions, accounts);

           Console.WriteLine(UpdatedAccounts);
                

       

        }     
     
    }

}
