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
            var tree = new AVLTree<int>();
            tree.InsertItem(25);
            tree.InsertItem(15);
            tree.InsertItem(10);
            tree.InsertItem(20);
            tree.InsertItem(23);
            tree.InsertItem(17);
            Console.WriteLine(tree.InOrder());
            Console.ReadKey();
        }
    }
}