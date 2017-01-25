using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedListGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new LinkListGen<string>();
            list.AppendItem("Hello World!");
            list.AppendItem("My name is");
            list.AppendItem("Elliot Lewis.");
            list.AppendItem("And this is a");
            list.AppendItem("Test List!");
            list.Sort();
            Console.WriteLine(list.DisplayList());
            Console.ReadKey();
        }
    }
}