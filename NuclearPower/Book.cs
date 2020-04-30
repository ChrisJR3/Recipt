using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPower
{
    class Book
    {
        public int referenceNumber;
        public string bookTitle;

        public Book(int _referenceNumber, string _bookTitle)
        {
            referenceNumber = _referenceNumber;
            bookTitle = _bookTitle;
        }
    }
}
