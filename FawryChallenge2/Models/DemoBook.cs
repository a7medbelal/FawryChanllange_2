using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Models
{
    public class DemoBook : Book
    {

        public DemoBook(string isbn, string title, int yearPublished, string author, double price )
            : base(isbn, title, yearPublished, author, price)
        {
          
        }

        public override double Buy(int quantity, string adderess, string email)
        {
            throw new InvalidOperationException("Demo books are not for sale.");
        }
    }
}
