using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    internal class LibraryCatalogue : ILibraryCatalogue
    {
        // Array defined to implement the key - value pair of a dictionary
        Book[] Books = new Book[100];
        int CountBooks = 0;
        string Genre;
        
        public string Genre1 { get => Genre; set => Genre = value; }
        // Constructor defined to assign a book to particular key i.e. its genre
        public LibraryCatalogue(string genre, Book book)
        {
            Genre1 = genre;
            Books[CountBooks] = book;
            CountBooks++;
        }
        // Function to add a book to a particular genre
        public void AddBook(Book book)
        {
            Books[CountBooks] = book;
            CountBooks++;
        }
        // Function to remove a book from a particular genre
        public void RemoveBook(string bookName)
        {
            for (int loop = 0; loop < CountBooks; loop++)
            {
                if (Books[loop].BookTitle1.Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    Books[loop] = null;
                    for(int book = loop; book < CountBooks-1; book++)
                    {
                        Books[book] = Books[book + 1];
                    }
                    Console.WriteLine("Book SuccessFully Removed!");
                    return;
                }
            }
        }
        // Function to display all the books in a particular genre
        public void ToString()
        {
            string result = "";
            for (int loop = 0; loop < CountBooks; loop++)
            {
                if (Books[loop] == null)
                {
                    continue;
                }
                Console.WriteLine((loop+1)+". "+Books[loop].ToString());
                Console.WriteLine();
            }
        }
        // Function to update availability status after borrowing of a book
        public void BorrwStatus(int book)
        {
            if(Books[book].BookAvailability1)
            {
                Console.WriteLine("The book has been issued in your name!");
                Books[book].BookAvailability1 = !Books[book].BookAvailability1;
            }
            else
            {
                Console.WriteLine("We are sorry. The Book is unavailable. Please try again later.");
            }
        }
        // Function to update availability status after returning of a book
        public void ReturnBookStatus(string bookName)
        {
            for(int loop = 0; loop < CountBooks; loop++)
            {
                if (Books[loop].BookTitle1.Equals(bookName,StringComparison.OrdinalIgnoreCase))
                {
                    if (!Books[loop].BookAvailability1)
                    {
                        Console.WriteLine($"The book {Books[loop].BookTitle1} in the Genre {Genre1} has been returned.");
                        Books[loop].BookAvailability1 = true;
                    }
                }
            }
        }
    }
}
