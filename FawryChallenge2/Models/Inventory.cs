using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Models
{
    internal class Inventory
    {
        // Limit age for books in years this can the admin of the inventory can change 
        private const int LimitAge = 10;
        public List<Book> Books { get; set; } = new List<Book>();
        public Inventory() { }

        public void AddBook(Book book)
        {
            if (Books.Contains(book))
            {
                Console.WriteLine("Book is already Exists in the System");
                return;
            }
            if(book is null )
            {
                Console.WriteLine("Book is null, cannot add to inventory.");
                return;
            }
            Books.Add(book);
            Console.WriteLine($"#= Book {book.Title} added to inventory.\n");
        }


        public void RemoveBook(Book book)
        {
            if (book is null )
            {
                Console.WriteLine("Book is null, cannot remove from inventory.");
                return;
            }
            Books.Remove(book);
            Console.WriteLine($"Book {book.Title} removed from inventory.");
        }

        public void DisplayInventory()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books in inventory.");
                return;
            }
            Console.WriteLine("Current Inventory:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} ({book.YearPublished}) - ISBN: {book.ISBN}, Price: {book.Price:C}");
            }
        }

        public List<Book> RemoveOutdatedBooks()
        {
           var outdatedBooks = Books.Where(b => DateTime.Now.Year - b.YearPublished > LimitAge).ToList();
            foreach (var book in outdatedBooks)
            {
                RemoveBook(book);
            }
            return outdatedBooks;
        }
        public Book SearchByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                Console.WriteLine("ISBN cannot be null or empty.");
                return null;
            }
            var book = Books.Where(b => b.ISBN == isbn).FirstOrDefault();
            if (book == null)
            {
                Console.WriteLine($"No book found with ISBN: {isbn}");
            }
            return book;
        }


        public double BuyBook(int quantity , string ISBN ,string email ,string Address)
        {
            var book = SearchByISBN(ISBN);
            if (book == null)
                throw new ArgumentException("Book with the given ISBN not found.");
            //here delegate the buy logic to the book class
            return book.Buy(quantity , Address ,email); 
        }
        
    } 
}
