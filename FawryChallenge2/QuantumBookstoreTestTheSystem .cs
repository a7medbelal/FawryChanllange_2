using FawryChallenge2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2
{
    public class QuantumBookstoreTestTheSystem
    {
        /// <summary>
        /// this test the system by creating an inventory and adding books to it
        ///     
        public static void Main(string[] args)
        {
            // Initialize the inventory
            Console.WriteLine("---------MAKE THE INVENTROY--------"); 
            var inventory = new Inventory();
            // Create some books
            //hrere we create some paper books to test the system PaperBook(string isbn, string title, int yearPublished, string author, double price, int quantityAvailable )
            var book1 = new PaperBook("P123", "Clean Code", 2019, "Robert Martin", 300, 5);
            var book2 = new PaperBook("P456", "The Pragmatic Programmer", 2018, "Andrew Hunt", 250, 3);
            var book3 = new PaperBook("P789", "Design Patterns", 2010, "Erich Gamma", 400, 2);


            // Create some DemoBook to test the system Ebook(string isbn, string title, int yearPublished, string author, double price)
            var demoBook = new DemoBook("D123", "Demo Frist Editon ", 2023, "Demo Author", 100);
            var demoBook2 = new DemoBook("D456", "Demo second Edition", 2023, "Demo Author 2", 100);
            var demoBook3 = new DemoBook("D789", "Demo third Edition", 2023, "Demo Author 3", 100);


            // Create some ebooks to test the system Ebook(string isbn, string title, int yearPublished, string author, double price, string fileType)

            var ebook1 = new Ebook("E123", "Learning C#", 2022, "John Doe", 50, "PDF");
            var ebook2 = new Ebook("E456", "Mastering ASP.NET", 2021, "Jane Smith", 60, "Word");

            // Add books to the inventory
            Console.WriteLine("## Quantum book store: Adding books to inventory...\n");
            inventory.AddBook(book1);
            inventory.AddBook(book2);
            inventory.AddBook(book3);
            inventory.AddBook(demoBook);
            inventory.AddBook(demoBook2);
            inventory.AddBook(demoBook3);
            inventory.AddBook(ebook1);
            inventory.AddBook(ebook2);

            // Display the inventory
            Console.WriteLine("Quantum book store: Removing outdated books...");
            inventory.DisplayInventory();

            Console.WriteLine("----------------------------------------\n");

            //remove outdated books with date than 10 years
            //this make with the admin as a const  date for the book to be outdated
            Console.WriteLine("Quantum book store: Removing outdated books...");
            var outdatedBooks = inventory.RemoveOutdatedBooks();
            Console.WriteLine("Removed outDateBooks ");
            Console.WriteLine("--------------------------------------------\n");


            /// test the Buy method for paper books
            /// 
            try
            {
                double total = inventory.BuyBook(1, "P123", "customer@email.com", "123 Street");
                Console.WriteLine($"Quantum book store: Paid amount = {total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something happen inour System  : " + ex.Message);
            }


            // test the Buy method for demo books
            try
            {
                double total = inventory.BuyBook(2, "D123", "ahmed@gmail.com", "cairo ");
                Console.WriteLine($"Quantum book store: Paid amount = {total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something happen in our System  : " + ex.Message);
            }




            // test the Buy method for ebooks
            // you only can buy one ebook at a time
            try
            {
                double total = inventory.BuyBook(1, "E123", "ahmed@gmail.com", "cairo");
                Console.WriteLine($"Quantum book store: Paid amount = {total}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something happen in our System  : " + ex.Message);
            }



        }
    }
}
