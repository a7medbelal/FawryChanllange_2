using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Models
{
    /// <summary>
    /// by make this class abstract we can not create an instance of it
    /// we can use it as a base class for other book types
    /// we can extend our system in the future by adding more book types
    /// here we define the common properties and methods for all book types
    /// </summary>
    abstract public class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public int YearPublished { get; }
        public string Author { get; }
        public double Price { get; }
        public Book(string isbn, string title, int yearPublished, string author, double price)
        {
            ISBN = isbn;
            Title = title;
            YearPublished = yearPublished;
            Author = author;
            Price = price;
        }
        public abstract double Buy(int quantity , string adderess , string email);
    }
}
