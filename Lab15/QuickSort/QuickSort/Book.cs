using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Book : IComparable
    {
        public string Isbn;
        public string Title;
        public string Author;
        public Book(string isbn, string title, String author)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
        }
        public override string ToString()
        {
            return Title + " by " + Author + " ISBN: " + Isbn;
        }

        public int CompareTo(Object other)
        {
            var o = (Book) other;
            return string.Compare(Title, o.Title, StringComparison.Ordinal);
        }
    }
}
