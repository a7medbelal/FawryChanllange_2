using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge2.interfaces
{
    internal interface IShippedService
    {
       void ShipBook(string bookTitle, string address);
    }
}
