using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.digital_bookshelf
{
    // Sealed class to prevent inheritance of the class
    sealed class DigitalBookShelfMenu
    {
        // Object of the interface(base) class to call methods of the Utility(chid) class
        IDigitalBookShelf BookShelf;
        // Function to display a menu for the user
        public void HomeMenu()
        {
            BookShelf = new DigitalBookShelfImpl();
            Console.WriteLine("Welcome To Your Personal Book Shelf!");
            while (true)
            {
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Sort the Books in the Shelf");
                Console.WriteLine("3. Display all the Books");
                Console.WriteLine("4. Search a Book");
                Console.Write("Select what would you like to do : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        Console.WriteLine("Thank you for your efforts.");
                        return;
                    case 1:
                        BookShelf.AddABook();
                        break;
                    case 2:
                        BookShelf.SortingBooksInTheShelf();
                        break;
                    case 3:
                        BookShelf.DisplayBookShelf();
                        break;
                    case 4:
                        BookShelf.SearchBook();
                        break;
                }
            }
        }
    }
}
