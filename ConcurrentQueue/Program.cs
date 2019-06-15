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
            DemoConcurrentQueue();
            Console.WriteLine("****************");
            DemoConcurrentStack();
            Console.WriteLine("****************");
            DemoConcurrentBag();
            Console.WriteLine("****************");
            DemoInterface();
        }

        private static void DemoConcurrentQueue()
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

            Console.WriteLine("\r\nEnumerating:");
            foreach (string item in shirts)
                Console.WriteLine(item);

            Console.WriteLine("\r\nAfter enumerating, count = " + shirts.Count.ToString());
        }
        private static void DemoConcurrentStack()
        {
            var shirts = new ConcurrentStack<string>();
            shirts.Push("Pluralsight");
            shirts.Push("WordPress");
            shirts.Push("Code School");

            Console.WriteLine("After Push, count = " + shirts.Count.ToString());

            string item1; //= shirts.Dequeue();
            bool success = shirts.TryPop(out item1);
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

            Console.WriteLine("\r\nEnumerating:");
            foreach (string item in shirts)
                Console.WriteLine(item);

            Console.WriteLine("\r\nAfter enumerating, count = " + shirts.Count.ToString());
        }
        private static void DemoConcurrentBag()
        {
            var shirts = new ConcurrentBag<string>();
            shirts.Add("Pluralsight");
            shirts.Add("WordPress");
            shirts.Add("Code School");

            Console.WriteLine("After enqueuing, count = " + shirts.Count.ToString());

            string item1; //= shirts.Dequeue();
            bool success = shirts.TryTake(out item1);
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

            Console.WriteLine("\r\nEnumerating:");
            foreach (string item in shirts)
                Console.WriteLine(item);

            Console.WriteLine("\r\nAfter enumerating, count = " + shirts.Count.ToString());
        }
        private static void DemoInterface()
        {
            // can change this to concurrent stack or bag
            IProducerConsumerCollection<string> shirts = new ConcurrentQueue<string>();
            shirts.TryAdd("Pluralsight");
            shirts.TryAdd("WordPress");
            shirts.TryAdd("Code School");

            Console.WriteLine("After enqueuing, count = " + shirts.Count.ToString());

            string item1; // = shirts.Dequeue();
            bool success = shirts.TryTake(out item1);
            if (success)
                Console.WriteLine("\r\nRemoving " + item1);
            else
                Console.WriteLine("queue was empty");

            Console.WriteLine("\r\nEnumerating:");
            foreach (string item in shirts)
                Console.WriteLine(item);

            Console.WriteLine("\r\nAfter enumerating, count = " + shirts.Count.ToString());
        }




    }
}
