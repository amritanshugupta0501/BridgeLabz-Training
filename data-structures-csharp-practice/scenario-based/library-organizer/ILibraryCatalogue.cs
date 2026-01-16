using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    // Interface of the Catalogue section of the library organizer system
    internal interface ILibraryCatalogue
    {
        string Genre1 { get ; set ; }
        void AddBook(Book book);
        void RemoveBook(string bookName);
        void ToString();
        void BorrwStatus(int book);
        void ReturnBookStatus(string bookName);

    }
}
