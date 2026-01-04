using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class BookLibrary
    {
        public int isbn;
        protected string title;
        private string author;
        public BookLibrary(string title, int isbn)                          // Constructor defined to get attributes of book
        {
            this.isbn = isbn;
            this.title = title;
        }
        public void SetAuthor(string author)                                // Setter method for private variable author
        {
            this.author = author;
        }
        public string GetAuthor()                                           // Getter method for private variable author
        {
            return this.author;
        }
    }
    class EBook : BookLibrary                                               // EBook class inheriting properties of BookLibrary class
    {
        public EBook(string title, int isbn) : base(title, isbn)            // Constructor defined of derived class
        {
        }
        public void DisplayDetails()                                        // Function to display details of Book
        {
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("ISBN number of book : " + isbn);
            Console.WriteLine("Book Author : " + GetAuthor());
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Give Book title : ");
            string title = Console.ReadLine();
            Console.Write("Give Book ISBN number : ");
            int isbn = int.Parse(Console.ReadLine());
            Console.Write("Give Book Author : ");
            string author = Console.ReadLine();
            EBook book = new EBook(title, isbn);
            book.SetAuthor(author);
            book.DisplayDetails();

        }
    }
}
