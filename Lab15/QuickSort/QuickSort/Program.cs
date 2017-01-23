using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] titles = { "Writing Solid Code", "Objects First", "Programming Gems", "Head First Java", "The C Programming Language", "Mythical Man Month", "The Art of Programming", "Coding Complete", "Design Patterns", "Problem Solving in Java" };
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };
            var library = new Book[10];
            for (var i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
            }
            QuickSort(library, 0, library.Length - 1);
            foreach (var book in library) {
                Console.WriteLine(book);
            }
            Console.ReadKey();
        }
        private static void QuickSort<T>(T[] items, int left, int right) where T : IComparable
        {
            while (true) {
                var i = left;
                var j = right;
                var pivot = items[left];
                while (i <= j) {
                    for (; (items[i].CompareTo(pivot) < 0) && (i < right); i++) ;
                    for (; (pivot.CompareTo(items[j]) < 0) && (j > left); j--) ;
                    if (i <= j)
                        Swap(ref items[i++], ref items[j--]);
                }
                if (left < j) QuickSort(items, left, j);
                if (i < right) {
                    left = i;
                    continue;
                }
                break;
            }
        }
        private static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}
