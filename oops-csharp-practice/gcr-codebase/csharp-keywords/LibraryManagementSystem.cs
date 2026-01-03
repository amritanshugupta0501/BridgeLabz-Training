using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpkeywords
{
    internal class LibraryManagementSystem
    {
        public static string libraryName = "City Library";
        public readonly string isbn;
        public string title;
        public string author;
        public LibraryManagementSystem(string title, string author, string isbn)                        // Constructor defined to get attributes of a book
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }
        public static void DisplayLibraryName()                                                         // Function to display the library name which is a class variable
        {
            Console.WriteLine("Welcome to "+libraryName);
        }
        public void ShowBookDetails()                                                                   // Function to display details of the book
        {
            Console.WriteLine("Title of the book : "+title);
            Console.WriteLine("Author of the book : "+author);
            Console.WriteLine("ISBN of the book : "+isbn);
        }
    }
    class Program
    {
        static void Main()                                                                              // Entry point program of the application
        {
            LibraryManagementSystem.DisplayLibraryName();
            Console.WriteLine();
            Console.WriteLine("Give details of the book : ");
            Console.Write("Give the title of the book : ");
            string book1 = Console.ReadLine();
            Console.Write("Give the author of the book : ");
            string author1 = Console.ReadLine();
            Console.Write("Give the ISBN of the book : ");
            string isbn1 = Console.ReadLine();
            LibraryManagementSystem library = new LibraryManagementSystem(book1, author1, isbn1);       // Constructor called to create an instance of the application
            if(library is LibraryManagementSystem)                                                      // Checking the type of object using 'is' operator
            {
                library.ShowBookDetails();
            }
            else
            {
                Console.WriteLine("Invalid Object.");
            }
        }
    }
}
