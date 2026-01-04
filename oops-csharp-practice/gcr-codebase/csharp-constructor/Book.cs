using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class Book
    {
        string bookTitle;
        string bookAuthor;
        double bookPrice;
        public Book()
        {
            bookTitle = "C Programming";
            bookAuthor = "Dennis Richie";
            bookPrice = 3000;
        }
        public Book(string bookTitle, string bookAuthor, double bookPrice)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.bookPrice = bookPrice;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Book Name : " + bookTitle);
            Console.WriteLine("Book Author : " + bookAuthor);
            Console.WriteLine("Book Price : " + bookPrice);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            Book book = new Book();
            book.DisplayDetails();
            Console.Write("Give book name : ");
            string name = Console.ReadLine();
            Console.Write("Give book author : ");
            string author = Console.ReadLine();
            Console.Write("Give book price : ");
            double price = double.Parse(Console.ReadLine());
            Book book1 = new Book(name, author, price);
            book1.DisplayDetails();
        }
    }
}
