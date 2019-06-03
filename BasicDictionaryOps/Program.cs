using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDictionaryOps
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Dictionary<string, int>()
            {
                {"jDays", 4},
                {"technologyhour", 3}
            };
            Console.WriteLine(string.Format("No. of shirts in stock = {0}", stock.Count));

            stock.Add("JMA", 6);
            stock["buddhistgeeks"] = 5;

            stock["JMA"] = 7; // up from 6 - we just bought one			
            Console.WriteLine(string.Format("\r\nstock[JMA] = {0}", stock["JMA"]));

            stock.Remove("jDays");

            Console.WriteLine("\r\nEnumerating:");
            foreach (var keyValPair in stock)
            {
                Console.WriteLine("{0}: {1}", keyValPair.Key, keyValPair.Value);
            }
        }
    }
}
