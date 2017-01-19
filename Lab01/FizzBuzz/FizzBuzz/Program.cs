using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++) {
                var output = (i % 3 == 0) ? "Fizz" : null;
                output += (i % 5 == 0) ? "Buzz" : null;
                if (output == string.Empty) {
                    Console.WriteLine(i);
                }
                else {
                    Console.WriteLine(output);
                }
            }
            Console.ReadKey();
        }
    }
}
