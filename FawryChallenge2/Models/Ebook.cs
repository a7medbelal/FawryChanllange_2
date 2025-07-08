using FawryChallenge2.interfaces;
using FawryChallenge2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Models
{
    public class Ebook : Book
    {
        public string FileType { get; set; }
        IEmailService emailService = new EmailService(); 
        public Ebook(string isbn, string title, int yearPublished, string author, double price, string fileType)
            : base(isbn, title, yearPublished, author, price)
        {
            FileType = fileType;
        }
    


        public override double Buy(int quantity, string adderess, string email)
        {

            if (quantity != 1)
                throw new ArgumentException("you should take only one book in ebook ");

            // here we call the email services 
            emailService.SendBookVaiEmail(email, this);
            return Price; 
        }

    }
}
