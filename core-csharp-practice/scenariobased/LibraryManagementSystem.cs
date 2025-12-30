//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Authentication;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.scenariobased
//{
//    internal class LibraryManagementSystem
//    {
//        static void Main()
//        {
//            LibraryManagementSystem library = new LibraryManagementSystem();
//            library.SystemInitialize();
//        }
//        void SystemInitialize()
//        {
//            long adminPassword = SetAdminPassword();
//            int books = GetNumberOfBooks();
//            string[,] library = StoreDetailsOfBooks(books, adminPassword);
//            if(library[0,0] == null)
//            {
//                Console.WriteLine("The user is not admin");
//                return;
//            }
//            string searchBook = GetBookName();
//            string[] presentBooks = IsTheBookInTheLibrary(library, searchBook,books);
//            if (presentBooks[0] == null)
//            {
//                Console.WriteLine("The book is not present in the library.");
//            }
//            else if (presentBooks[1] == null && presentBooks[0] != null)
//            {
//                Console.WriteLine("Your selected book Details : ");
//                DisplayBookDetails(presentBooks[0], library, books);
//                Console.WriteLine("Do you want to borrow the book ? Yes or No...");
//                bool choice = GetCustomerChoice();
//            }
//            else
//            {
//                Console.WriteLine("Select the book you want to borrow : ");
//                for (int loop = 0; loop < books; loop++)
//                {
//                    if (presentBooks[loop] != null)
//                    {
//                        Console.Write((loop + 1) + ".");
//                        DisplayBookDetails(presentBooks[loop], library, books);
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }
//                bool borrow = true;
//                while(borrow)
//                {
//                    Console.WriteLine("Select the book you want to borrow : ");
//                    int bookSelect = int.Parse(Console.ReadLine());
//                    DisplayBookDetails(presentBooks[bookSelect - 1], library, books);
//                    string checkAvailable = CheckAvailability(library, presentBooks[bookSelect - 1]);
//                    if (checkAvailable.Equals("false"))
//                    {
//                        Console.WriteLine("Sorry! the book is not available.");
//                    }
//                    else
//                    {
//                        if (CheckAdmin(adminPassword))
//                        {
//                            Console.WriteLine("The book is issued in your name.");
//                            library = ChangeAvailability(library, presentBooks[bookSelect - 1]);
//                        }
//                        else
//                        {
//                            Console.WriteLine("You don't have the admin password.");
//                            return;
//                        }
//                    }
//                    Console.WriteLine("Do you want to borrow more books ? Say yes or no...");
//                    string borrowBook = Console.ReadLine();
//                    if(borrowBook.ToLower().Equals("yes"))
//                    {
//                        borrow = true;
//                    }
//                    else
//                    {
//                        borrow = false;
//                    }
//                }
//            }
//        }
//        long SetAdminPassword()
//        {
//            Console.WriteLine("Set the admin password : ");
//            long password = long.Parse(Console.ReadLine());
//            return password;
//        }
//        bool CheckAdmin(long adminPassword)
//        {
//            Console.WriteLine("Enter Admin Password : ");
//            long password = long.Parse(Console.ReadLine());
//            return password == adminPassword;
//        }
//        int GetNumberOfBooks()
//        {
//            Console.Write("Give the number of books in the library : ");
//            int number = int.Parse(Console.ReadLine());
//            return number;
//        }
//        string[,] StoreDetailsOfBooks(int books, long adminPassword)
//        {            
//            string[,] library = new string[books,3];
//            if (CheckAdmin(adminPassword))
//            {
//                for (int loop = 0; loop < books; loop++)
//                {
//                    Console.WriteLine("Book " + (loop + 1) + " Details : ");
//                    Console.Write("Book title : ");
//                    library[loop, 0] = Console.ReadLine();
//                    Console.Write("Book Author : ");
//                    library[loop, 1] = Console.ReadLine();
//                    library[loop, 2] = true.ToString();
//                    Console.WriteLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("You are not the admin of the Program.");
//            }
//            return library;
//        }
//        string GetBookName()
//        {
//            Console.Write("Give the name of the book customer wants : ");
//            string bookName = Console.ReadLine();
//            return bookName;
//        }
//        string[] IsTheBookInTheLibrary(string[,] library, string book, int books)
//        {
//            string[] booksPresent = new string[books];
//            int index = 0;
//            for(int loop = 0; loop < books; loop++)
//            {
//                if(library[loop, 0] == book)
//                {
//                    booksPresent[index] = library[loop, 0];
//                    index++;
//                }
//                if (library[loop,0].IndexOf(book)!=-1)
//                {
//                    booksPresent[index] = library[loop, 0];
//                    index++;
//                }           
//            }
//            return booksPresent;
//        }
//        void DisplayBookDetails(string book, string[,] library,int books) 
//        {
//            for(int loop = 0; loop < books; loop++)
//            {
//                if (library[loop,0].Equals(book))
//                {
//                    Console.WriteLine("Book Details : ");
//                    Console.WriteLine("Book Title : " + library[loop,0]);
//                    Console.WriteLine("Book Author : " + library[loop,1]);
//                    Console.WriteLine();
//                    return;
//                }
//            }
//        }
//        bool GetCustomerChoice()
//        {
//            string choice = Console.ReadLine();
//            choice = choice.ToLower();
//            if(choice.Equals("yes"))
//            {
//                return true;
//            }
//            return false;
//        }
//        string CheckAvailability(string[,] library,string book)
//        {
//            for (int loop = 0; loop < library.GetLength(0); loop++)
//            {
//                if (library[loop,0].Equals(book))
//                {
//                    return library[loop, 2];
//                }
//            }
//            return null;
//        }
//        string[,] ChangeAvailability(string[,] library,string book)
//        {
//            for(int loop =0; loop < library.GetLength(0);loop++)
//            {
//                if(library[loop,0].Equals(book))
//                {
//                    library[loop, 2] = "false";
//                    return library;
//                }
//            }
//            return library;
//        }
//    }
//}
