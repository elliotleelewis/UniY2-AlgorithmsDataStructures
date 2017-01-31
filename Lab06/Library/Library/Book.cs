using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library
{
    internal class Book
    {
        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
            OnLoan = false;
        }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public bool OnLoan { get; set; }
    }
}