using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Recursion
{
    internal class Program
    {
        private static void PrintNumbers(int n)
        {
            if (n > 0) {
                Console.WriteLine(" n = {0} ", n);
                PrintNumbers(Dec(n));
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }
        private static void Range(int start, int stop)
        {
            if (stop < start) {
                return;
            }
            Console.WriteLine(start);
            if (start < stop) {
                Range(Inc(start), stop);
            }
        }
        private static string GetNumberString(int n)
        {
            if (n == 0)
                return "";
            else {
                return n + ", " + GetNumberString(Dec(n));
            }
        }
        private static int Multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else {
                return x + Multiply(x, Dec(y));
            }
        }
        private static int Power(int x, int y)
        {
            if (y == 1) {
                return x;
            }
            else {
                return x * Power(x, Dec(y));
            }
        }
        private static int Inc(int x)
        {
            return x + 1;
        }
        private static int Dec(int x)
        {
            return x - 1;
        }
        private static void Main(string[] args)
        {
            PrintNumbers(5);
            Range(15, 10);
            Console.WriteLine(GetNumberString(5));
            Console.WriteLine(Multiply(5, 10));
            Console.WriteLine(Power(3, 3));
            Console.ReadKey();
        }
    }
}