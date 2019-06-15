using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var shirts = new ConcurrentQueue<string>();
            shirts.Enqueue("Pluralsight");
            shirts.Enqueue("WordPress");
            shirts.Enqueue("Code School");

            Console.WriteLine("After enqueuing, count = " + shirts.Count.ToString());

            string item1; //= shirts.Dequeue();
            bool success = shirts.TryDequeue(out item1);
            if (success)
                Console.WriteLine("\r\nRemoving " + item1);
            else
                Console.WriteLine("queue was empty");

            string item2; //= shirts.Peek();
            success = shirts.TryPeek(out item2);
            if (success)
                Console.WriteLine("Peeking   " + item2);
            else
                Console.WriteLine("queue was empty");

            Console.WriteLine("\r\nEnumerating:");s
            foreach (string item in shirts)
                Console.WriteLine(item);

            Console.WriteLine("\r\nAfter enumerating, count = " + shirts.Count.ToString());
        }
    }
}
