using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookSort
{
    internal class Book
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

        internal int CompareTo(Book other)
        {
            return string.Compare(Title, other.Title, StringComparison.Ordinal);
        }
    }
}