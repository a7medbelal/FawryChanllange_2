using FawryChallenge2.interfaces;
using FawryChallenge2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Models
{
    public class PaperBook : Book
    {
        // here we use the shipping service to handle the shipping logic
        //this compestion is used to decouple the shipping logic from the book class

        IShippedService _shippedService = new ShippingService();
        public int QuantityAvailable { get; set; }

        public PaperBook(string isbn, string title, int yearPublished, string author, double price, int quantityAvailable )
            : base(isbn, title, yearPublished, author, price )
        {
            QuantityAvailable = quantityAvailable;
       
        }

        public override double Buy(int quantity, string adderess, string email)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            if (QuantityAvailable < quantity)
            {
                throw new InvalidOperationException("Insufficient stock available.");
            }
            QuantityAvailable -= quantity;
            var totalCost = Price * quantity;   
            Console.WriteLine($"Purchased {quantity} copies of '{Title}' by {Author}. Total cost: {totalCost:C}");
       
            // here we assume that the shipping service will handle the shipping logic and i can just call it
            _shippedService.ShipBook(Title, adderess);
            return totalCost;
        }

    }
}
