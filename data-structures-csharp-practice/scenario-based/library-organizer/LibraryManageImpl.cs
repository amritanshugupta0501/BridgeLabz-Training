using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    internal class LibraryManageImpl : ILibraryManagement
    {
        // Array defined to assign books to different genres or to implement a dictionary
        ILibraryCatalogue[] LibraryBook = new ILibraryCatalogue[100];
        int CountGenres;
        // Function to add a book in the library
        public void AddABookInLibrary()
        {
            Console.WriteLine("Give the Book Details : ");
            Console.Write("Book Title : ");
            string title = Console.ReadLine();
            Console.Write("Book Author : ");
            string author = Console.ReadLine();
            Console.Write("Book Genres : ");
            string genres = Console.ReadLine();
            Console.Write("Book Rental Price : ");
            string rentalPrice = Console.ReadLine();
            bool bookAvailability = true;
            Book book = new Book(title,author,genres,bookAvailability,rentalPrice);
            CheckGenre(book);
        }
        // Function to check and assign the book to its particular genre
        public void CheckGenre(Book book)
        {
            string[] genres = book.BookGenres1.Split(',');

            for (int loop = 0; loop < genres.Length; loop++)
            {
                int checker = 0;
                for (int genre = 0; genre < CountGenres; genre++)
                {
                    if (genres[loop].Equals(LibraryBook[genre].Genre1, StringComparison.OrdinalIgnoreCase))
                    {
                        checker = 1;
                        LibraryBook[genre].AddBook(book);
                        break;
                    }
                }
                if (checker == 0)
                {
                    LibraryBook[CountGenres] = new LibraryCatalogue(genres[loop], book);
                    CountGenres++;
                }
            }
        }
        // Function to display books in the library
        public void DisplayBooks()
        {
            for(int loop = 0; loop < CountGenres; loop++)
            {
                Console.WriteLine("Genre : " + LibraryBook[loop].Genre1);
                LibraryBook[loop].ToString();
            }
        }
        // Function to display books in a particular genre
        public void DisplayBooksInAGenre()
        {
            Console.WriteLine("Select your genre : ");
            for(int loop = 0;loop < CountGenres; loop++)
            {
                Console.WriteLine((loop+1)+". "+LibraryBook[loop].Genre1); 
            }
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Books in the Genre " + LibraryBook[choice - 1].Genre1+" : ");
            LibraryBook[choice - 1].ToString();
        }
        // Function to discard a book from the library
        public void RemoveBook()
        {
            Console.Write("Give the book name you want to remove : ");
            string bookName = Console.ReadLine();
            for(int loop = 0; loop < CountGenres; loop++)
            {
                LibraryBook[loop].RemoveBook(bookName);

            }
        }
        // Function to borrow a book from the library
        public void BorrowBook()
        {
            Console.WriteLine("Select your genre : ");
            for (int loop = 0; loop < CountGenres; loop++)
            {
                Console.WriteLine((loop + 1) + ". " + LibraryBook[loop].Genre1);
            }
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Books in the Genre " + LibraryBook[choice - 1].Genre1 + " : ");
            LibraryBook[choice - 1].ToString();
            Console.Write("Select the book you would like to borrow : ");
            int choiceBook = int.Parse(Console.ReadLine());
            LibraryBook[choice - 1].BorrwStatus(choiceBook - 1);
        }
        // Function to return a book to the library
        public void ReturnABook()
        {
            Console.Write("Give the name of the book you want to return : ");
            string bookName = Console.ReadLine();
            for(int loop = 0; loop < CountGenres; loop++)
            {
                LibraryBook[loop].ReturnBookStatus(bookName);
            }
        }
    }
}
