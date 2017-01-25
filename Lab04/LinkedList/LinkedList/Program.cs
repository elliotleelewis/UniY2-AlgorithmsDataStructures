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
            var list = new LinkList();
            list.AddItem(8);
            list.AddItem(6);
            list.AddItem(4);
            list.AddItem(2);
            list.InsertInOrder(5);
            Console.WriteLine("List items: {0}", list.DisplayItems());
            Console.WriteLine("List length: {0}", list.NumberOfItems());
            Console.ReadKey();
        }
    }
}