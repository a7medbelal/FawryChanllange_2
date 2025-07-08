using FawryChallenge2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.interfaces
{
    internal interface IEmailService
    {
        void SendBookVaiEmail(string email, Ebook ebook);
    }
}
