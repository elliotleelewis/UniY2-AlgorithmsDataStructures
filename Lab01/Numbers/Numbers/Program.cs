using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            partC();
        }
        private static void partA()
        {
            Console.WriteLine("Enter 1st Number: ");
            var input = Console.ReadLine();
            var num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number: ");
            input = Console.ReadLine();
            var num2 = Convert.ToInt32(input);
            Console.WriteLine("Sum is: {0}", sum(num1, num2));
            Console.ReadKey();
        }
        private static void partB()
        {
            Console.WriteLine("Enter 1st Number: ");
            var input = Console.ReadLine();
            var num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number: ");
            input = Console.ReadLine();
            var num2 = Convert.ToInt32(input);
            Console.WriteLine("Sum is: {0}", pow(num1, num2));
            Console.ReadKey();
        }
        private static void partC()
        {
            var counter = 0;
            var total = 0;
            string input;
            while (isNumeric(input = getInput())) {
                counter++;
                total += Convert.ToInt32(input);
                var average = total / counter;
                Console.WriteLine("Average: {0}", average);
            }
        }
        private static int sum(int x, int y)
        {
            return x + y;
        }
        private static int pow(int x, int y)
        {
            var result = 1;
            for (var i = 0; i < y; i++) {
                result *= x;
            }
            return result;
        }
        static string getInput()
        {
            Console.WriteLine("Enter number:");
            return Console.ReadLine();
        }
        static bool isNumeric(string input)
        {
            try {
                Convert.ToInt32(input);
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }
    }
}
