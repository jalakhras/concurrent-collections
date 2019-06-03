using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace concurrent_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new ConcurrentQueue<string>();
            //PlaceOrders(orders, "Mark");
            //PlaceOrders(orders, "Ramdevi");
            Task task1 = Task.Run(() => PlaceOrders(orders, "Jassar"));
            Task task2 = Task.Run(() => PlaceOrders(orders, "Mahmoud"));

            Task.WaitAll(task1, task2);
            foreach (string order in orders)
                Console.WriteLine("ORDER: " + order);
        }
        static void PlaceOrders(ConcurrentQueue<string> orders, string customerName)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1);
                string orderName = string.Format("{0} wants t-shirt {1}", customerName, i + 1);
                orders.Enqueue(orderName);
            }
        }
    }
}
