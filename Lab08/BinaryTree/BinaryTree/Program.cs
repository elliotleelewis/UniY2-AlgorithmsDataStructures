using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = new Node<string>("A");
            var b = new Node<string>("B");
            var c = new Node<string>("C");
            var d = new Node<string>("D");
            var e = new Node<string>("E");
            var f = new Node<string>("F");
            var g = new Node<string>("G");
            var h = new Node<string>("H");
            a.Left = b;
            b.Left = d;
            b.Right = e;
            e.Right = h;
            a.Right = c;
            c.Left = f;
            c.Right = g;
            var tree = new BinTree<string>(a);
            Console.WriteLine(tree.InOrder());
            Console.WriteLine(tree.PreOrder());
            Console.WriteLine(tree.PostOrder());
            Console.WriteLine(tree.Count());
            var tree2 = new BinTree<string>();
            tree2.Copy(tree);
            Console.WriteLine(tree2.InOrder());
            Console.ReadKey();
        }
    }
}