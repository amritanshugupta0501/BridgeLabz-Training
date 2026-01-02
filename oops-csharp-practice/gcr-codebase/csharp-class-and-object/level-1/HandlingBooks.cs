using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.classandobject
{
    internal class HandlingBooks
    {
        string titleOfBook;
        string authorOfBook;
        int priceOfBook;
        public HandlingBooks(string titleOfBook, string authorOfBook, int priceOfBook)      // Constructor to define characteristics of the book
        {
            this.titleOfBook = titleOfBook;
            this.authorOfBook = authorOfBook;
            this.priceOfBook = priceOfBook;
        }
        public void DisplayDetailsOfTheBook()                                               // Function to display details of the book
        {
            Console.WriteLine("Book Details : ");
            Console.WriteLine("Book Title : " + titleOfBook);
            Console.WriteLine("Author of book : " + authorOfBook);
            Console.WriteLine("Price of book : " + priceOfBook);
        }
    }
    internal class Program                                                                  // Program to initialize the entry point of the application
    {
        static void Main()                                                                  // Main method to define the entry point of the application
        {
            Console.WriteLine("Give the details of the book : ");
            Console.Write("Give title of the book : ");
            string titleOfBook = Console.ReadLine();
            Console.Write("Give author of the book : ");
            string authorOfBook = Console.ReadLine();
            Console.Write("Give price of the book : ");
            int priceOfBook = int.Parse(Console.ReadLine());
            HandlingBooks book = new HandlingBooks(titleOfBook, authorOfBook, priceOfBook); // Constructor called
            book.DisplayDetailsOfTheBook();
        }
    }
}
