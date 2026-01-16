using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    // Interface of the utility class of the library organizer system
    internal interface ILibraryManagement
    {
        void AddABookInLibrary();
        void CheckGenre(Book book);
        void DisplayBooks();
        void DisplayBooksInAGenre();
        void RemoveBook();
        void BorrowBook();
        void ReturnABook();
    }
}
