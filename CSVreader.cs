using System.Data;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace supportbank
{

    public class CSVreader

    {
        public static List<Transaction> ReadTransactionsFromfile()
            {
                var transactions = new List<Transaction>();

                var csv = File.ReadAllLines("DodgyTransactions2015.csv").Skip(1);

                foreach (var line in csv)
                {
                    var parts = line.Split(",");


                    var date = DateTime.Parse(parts[0],new CultureInfo("en-GB"));

                    var from = parts[1];
                    var to = parts[2];
                    var narrative = parts[3];

                    try{
                            var amount = Convert.ToDecimal(parts[4]);
                            var mytransaction = new Transaction(date,to,from,narrative,amount);
                    transactions.Add(mytransaction);
                    }
                    catch (FormatException mistake)
                    {
                            Console.WriteLine($"you enterered {parts[4]} which is an invalid format");
                            throw mistake;
                     
                    
                    }

                   
                 
                }

                return transactions;
            }
    }
}
