using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.digital_bookshelf
{
    internal interface IDigitalBookShelf
    {
        void AddABook();
        int CountTotalBooks();
        void SortingBooksInTheShelf();
        Book[] SortingTheBooks(Book[] collectionOfBooks);
        void DisplayBookShelf();
        void SearchBookByAuthor(string authorName);
        void SearchBookByTitle(string titleName);
        void SearchBook();
    }
}
