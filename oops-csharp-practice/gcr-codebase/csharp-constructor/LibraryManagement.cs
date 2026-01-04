using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class LibraryManagement
    {
        string bookTitle;
        string bookAuthor;
        double bookPrice;
        string availability;
        public LibraryManagement()
        {
            bookTitle = "C Programming";
            bookAuthor = "Dennis Richie";
            bookPrice = 3000;
            availability = "true";
        }
        public LibraryManagement(string bookTitle, string bookAuthor, double bookPrice, string availability)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
            this.availability = availability;
        }
        public void BorrowBook()
        {
            if (availability.ToLower().Equals("true"))
            {
                Console.WriteLine("Do you want to borrow the book ? Yes or No");
                string response = Console.ReadLine();
                if (response.ToLower().Equals("yes"))
                {
                    availability = "False";
                }
            }
            else
            {
                Console.WriteLine("Sorry the book is unavailable");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Name : " + bookTitle);
            Console.WriteLine("Book Author : " + bookAuthor);
            Console.WriteLine("Book Price : " + bookPrice);
            Console.WriteLine("Availability : " + availability);
        }
    }
    class Program
    {
        static void Main()
        {
            LibraryManagement book1 = new LibraryManagement();
            book1.DisplayDetails();
            book1.BorrowBook();
            book1.DisplayDetails();
            Console.WriteLine();
            Console.Write("Give book name : ");
            string book = Console.ReadLine();
            Console.Write("Give book author : ");
            string author = Console.ReadLine();
            Console.Write("Give book price : ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Give book availability (true or false) : ");
            string availability = Console.ReadLine();
            LibraryManagement book2 = new LibraryManagement(book, author, price, availability);
            book2.DisplayDetails();
            book2.BorrowBook();
            book2.DisplayDetails();
        }
    }
}
