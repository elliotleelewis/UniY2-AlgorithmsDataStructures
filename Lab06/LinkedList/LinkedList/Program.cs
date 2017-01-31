using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddBefore(list.Find(1), 3);
            list.AddAfter(list.Find(2), 4);
            list.AddFirst(5);
            list.RemoveLast();
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}