using System.Data;
using System;
using System.IO;


namespace supportbank
{

    public class CSVreader

    {
        static void Main(string[] args)
            {
                String csv = File.ReadAllText("Transactions2014.csv");
                    Console.WriteLine(csv);
    
            }
        
        public static int add(int value1,int value2)
        {
            return value1 + value2;
        }
        
    }
}
