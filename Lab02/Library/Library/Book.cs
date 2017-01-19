using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book : IComparable
    {
        public Book(string title)
        {
            this.Title = title;
        }
        public Book(string title, Person author)
        {
            this.Title = title;
            this.Author = author;
        }
        public string Title { get; set; }
        public Person Author { get; set; }
        public string getSummary()
        {
            return Title + " - " + Author.ToString();
        }
        public int CompareTo(object obj)
        {
            var other = (Book) obj;
            return string.Compare(other.Title, Title, StringComparison.Ordinal);
        }
    }
}
