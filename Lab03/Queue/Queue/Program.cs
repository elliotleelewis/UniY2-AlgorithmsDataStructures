using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Queue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var queue = new IntQueue();
            queue.Enqueue(5);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(7);
            queue.Enqueue(3);
            queue.Enqueue(9);
            queue.Enqueue(1);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Num of Items: {0}", queue.Count());
            Console.ReadKey();
        }
    }
}