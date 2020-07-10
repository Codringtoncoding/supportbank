using System.Data;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace supportbank
{

    public class CSVreader

    {
        public static List<Transaction> ReadTransactionsFromfile()
            {
                var transactions = new List<Transaction>();

                var csv = File.ReadAllLines("Transactions2014.csv").Skip(1);

                foreach (var line in csv)
                {
                    var parts = line.Split(",");

                    var date = parts[0];
                    var from = parts[1];
                    var to = parts[2];
                    var narrative = parts[3];
                    var amount = parts[4];
                    
                    Console.WriteLine(from + amount);
                }

                return transactions;
            }
    }
}
