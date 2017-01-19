using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book("Moby Dick", new Person("Herman Melville")));
            books.Add(new Book("Harry Potter and the Philosopher's Stone", new Person("J.K. Rowling")));
            books.Add(new Horror("The Shining"));
            books.Add(new Horror("Pet Sematary"));
            books.Add(new Novel("The Fault in Our Stars"));
            books.Add(new Novel("Paper Towns"));
            books.Add(new Fantasy("A Game of Thrones"));
            books.Add(new Fantasy("A Clash of Kings"));
            foreach (var book in books) {
                Console.WriteLine(book.getSummary());
            }
            Console.ReadKey();
        }
    }
}