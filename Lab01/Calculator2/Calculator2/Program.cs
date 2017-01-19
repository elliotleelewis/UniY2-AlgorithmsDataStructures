using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true) {
                try {
                    var sum = ReadEquation();
                    var parts = sum.Split(' ');
                    var numA = Convert.ToInt32(parts[0]);
                    var numB = Convert.ToInt32(parts[2]);
                    var arithmeticOperator = parts[1];
                    switch (arithmeticOperator) {
                        case "+":
                            Console.WriteLine("The result is: " + (numA + numB));
                            break;
                        case "-":
                            Console.WriteLine("The result is: " + (numA - numB));
                            break;
                        case "*":
                            Console.WriteLine("The result is: " + (numA * numB));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Error: Invalid equation.");
                }
                Console.WriteLine();
            }
        }
        private static string ReadEquation()
        {
            Console.WriteLine("Please enter an equation:");
            var sum = Console.ReadLine();
            if (sum.Split(' ').Length != 3)
            {
                throw new Exception();
            }
            return sum;
        }
    }
}
