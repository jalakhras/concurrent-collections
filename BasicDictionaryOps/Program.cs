using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace BasicDictionaryOps
{
    class Program
    {
        static void Main(string[] args)

        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("jDays", 4);
            stock.TryAdd("technologyhour", 3);
            Console.WriteLine(string.Format("No. of shirts in stock = {0}", stock.Count));

            var success =  stock.TryAdd("JMA", 6);
            Console.WriteLine("Added success ?  "+ success);

            success= stock.TryAdd("JMA", 6);
            Console.WriteLine("Added success ?  " + success);

            stock["buddhistgeeks"] = 5;

            //stock["JMA"] = 7; // up from 6 - we just bought one	
            //success = stock.TryUpdate("JMA", 7, 6);
            //Console.WriteLine("JMA = {0} , did Update Work? {1} ", stock["JMA"],success);

            //success = stock.TryUpdate("JMA", 8, 6);
            //Console.WriteLine("JMA = {0} , did Update Work? {1} ", stock["JMA"], success);

            // stock["JMA"]++ ; 
            int psStock = stock.AddOrUpdate("JMA", 1, (key, oldValue) => oldValue + 1);
            Console.WriteLine("New value is "+ psStock);

            Console.WriteLine(string.Format("stock[JMA] = {0}", stock.GetOrAdd("JMA",0)));


            Console.WriteLine(string.Format("\r\nstock[JMA] = {0}", stock["JMA"]));
            success = stock.TryRemove("jDays", out int jDaysValue);
            Console.WriteLine("Value removed was : " + jDaysValue);

            Console.WriteLine("\r\nEnumerating:");
            foreach (var keyValPair in stock)
            {
                Console.WriteLine("{0}: {1}", keyValPair.Key, keyValPair.Value);
            }
        }
    }
}
