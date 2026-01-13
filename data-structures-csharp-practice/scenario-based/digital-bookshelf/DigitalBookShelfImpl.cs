using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.digital_bookshelf
{
    // Utility class for the application
    internal class DigitalBookShelfImpl : IDigitalBookShelf
    {
        Book Head;
        // Function to add a book to the shelf
        public void AddABook()
        {
            Console.Write("Give the title of the book : ");
            string title = Console.ReadLine();
            Console.Write("Give the author of the book : ");
            string author = Console.ReadLine();
            Book newBook = new Book(title + "-" + author);
            if(Head ==null)
            {
                Head = newBook;
                return;
            }
            Book current = Head;
            while (current.Next != null )
            {
                current = current.Next;
            }
            current.Next = newBook;
        }
        // function to count total number of books in the shelf
        public int CountTotalBooks()
        {
            int count;
            Book current = Head;
            count = 0;
            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        // Function to initiate sorting algorithm for the books
        public void SortingBooksInTheShelf()
        {
            Book[] collectionOfBooks = new Book[CountTotalBooks()+1];
            int index = 0;
            Book current = Head;
            while (current != null) 
            {
                collectionOfBooks[index] = current;
                current = current.Next;
                index++;
            }
            collectionOfBooks = SortingTheBooks(collectionOfBooks);
            Head = collectionOfBooks[0];
            Book newCurrent = Head;
            for (int i = 1; i < collectionOfBooks.Length; i++)
            {
                newCurrent.Next = collectionOfBooks[i];
                newCurrent = newCurrent.Next;
            }
            newCurrent.Next = null;
        }
        // Sorting the books alphabetically in the shelf
        public Book[] SortingTheBooks(Book[] collectionOfBooks)
        {
            for (int outerLoop = 0; outerLoop < collectionOfBooks.Length; outerLoop++)
            {
                for (int innerLoop = outerLoop + 1; innerLoop < collectionOfBooks.Length; innerLoop++)
                {
                    char book1 = collectionOfBooks[innerLoop].BookDetail1[0];
                    char book2 = collectionOfBooks[outerLoop].BookDetail1[0];
                    if (book1 < book2)
                    {
                        Book swapper = collectionOfBooks[innerLoop];
                        collectionOfBooks[innerLoop] = collectionOfBooks[outerLoop];
                        collectionOfBooks[outerLoop] = swapper;
                    }
                }
            }
            return collectionOfBooks;
        }
        // Function to display all the books in shelf
        public void DisplayBookShelf()
        {
            Book current = Head;
            int length = CountTotalBooks();
            while (length >= 0)
            {
                string[] detail = current.BookDetail1.Split('-');
                Console.WriteLine($"Book Title : {detail[0]}\nBook Author : {detail[1]}");
                current = current.Next;
                length--;
            }
        }
        // Function Search a book in the shelf
        public void SearchBook()
        {
            Console.WriteLine("Select the criteria by which you want to search the book : \n1. Book Author\n2.Book Title");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Give the Author name by which you want to search : ");
                    string authorName = Console.ReadLine();
                    SearchBookByAuthor(authorName);
                    break;
                case 2:
                    Console.Write("Give the Title name by which you want to search : ");
                    string titleName = Console.ReadLine();
                    SearchBookByTitle(titleName);
                    break;
            }
        }
        // Function to search a book by author name in the shelf
        public void SearchBookByAuthor(string authorName)
        {
            Book current = Head;
            while (current != null)
            {
                string[] detail = current.BookDetail1.Split('-');
                if (authorName.ToLower().Equals(detail[1].ToLower()))
                {
                    Console.WriteLine($"Book Title : {detail[0]}\nBook Author : {detail[1]}");
                }
                current = current.Next;
            }
        }
        // Function to search a book by title name in the shelf
        public void SearchBookByTitle(string titleName)
        {
            Book current = Head;
            while (current != null)
            {
                string[] detail = current.BookDetail1.Split('-');
                if (titleName.ToLower().Equals(detail[0].ToLower()))
                {
                    Console.WriteLine($"Book Title : {detail[0]}\nBook Author : {detail[1]}");
                }
                current = current.Next;
            }
        }
    }
}
