using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = new BSTree<int>();
            tree.InsertItem(21);
            tree.InsertItem(7);
            tree.InsertItem(30);
            tree.InsertItem(3);
            tree.InsertItem(9);
            tree.InsertItem(24);
            tree.InsertItem(39);
            tree.InsertItem(12);
            Console.WriteLine(tree.InOrder());
            Console.WriteLine(tree.Contains(21));
            tree.RemoveItem(21);
            Console.WriteLine(tree.Contains(21));
            Console.WriteLine(tree.InOrder());
            Console.ReadKey();
        }
    }
}