using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookSort
{
    internal class Program
    {
        private static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
        private static void PrintArray(IEnumerable<int> a)
        {
            foreach (var t in a)
            {
                Console.Write(t + ",");
            }
            Console.WriteLine();
        }
        private static bool IsInOrder<T>(IReadOnlyList<T> a) where T : IComparable
        {
            for (var i = 0; i < a.Count - 1; i++)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                    return false;
            }
            return true;
        }
        private static void SelectionSort(Book[] library)
        {
            for (var i = 0; i < library.Length - 1; i++)
            {
                var smallest = i;
                for (var j = i + 1; j < library.Length; j++)
                {
                    if (library[j].CompareTo(library[smallest]) == -1)
                        smallest = j;
                }
                Swap(ref library[i], ref library[smallest]);
            }
        }
        private static void Main(string[] args)
        {
            string[] titles = { "Writing Solid Code", "Objects First", "Programming Gems", "Head First Java", "The C Programming Language", "Mythical Man Month", "The Art of Programming", "Coding Complete", "Design Patterns", "Problem Solving in Java" };
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };
            var library = new Book[10];
            for (var i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
            }
            SelectionSort(library);
            foreach (var book in library)
            {
                Console.WriteLine(" {0} ", book);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}