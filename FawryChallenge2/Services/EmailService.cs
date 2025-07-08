using FawryChallenge2.interfaces;
using FawryChallenge2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.Services
{
    internal class EmailService : IEmailService
    {
        public  void SendBookVaiEmail(string email, Ebook ebook)
        {
            Console.WriteLine("here can send the books to the email");
        }
    }
}
