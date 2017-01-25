using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            IntStack stack = new IntStack();
            while (!stack.IsFull()) {
                stack.Push(random.Next(100));
            }
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            System.Console.ReadKey();
        }
    }
}