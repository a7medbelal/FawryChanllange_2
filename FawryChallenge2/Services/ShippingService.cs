using FawryChallenge2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Services
{

    internal class ShippingService : IShippedService
    {
        public void ShipBook(string bookTitle, string address)
        {
            Console.WriteLine("here can ship the books to the adderes");
        }
    }
}
