using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new ArrayList {"First", "Second", "Third", "Fourth"};
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            list.Sort();
            Console.WriteLine();
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
