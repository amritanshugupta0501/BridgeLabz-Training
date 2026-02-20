using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    // Using sealed class to prevent inheritance of the menu class
    sealed class AddressBookMenu
    {
        // Object created using parent reference i.e. Interface IAddressBook to call the functionalities of the child class
        private IAddressBook AddressBook;
        IAddressBookManager manageAddressBooks;
        // Function to design the home menu of the application
        public void HomeMenu()
        {
            manageAddressBooks = new AddressBookManager();
            Console.WriteLine("Welcome to Address Book System Application!");
            while (true)
            {
                Console.WriteLine("1. Create an Address Book");
                Console.WriteLine("2. Display all Address Books");
                Console.WriteLine("3. Work in an Address Book");
                Console.WriteLine("4. View Entries by their city or state");
                Console.WriteLine("0. Exit the application");
                Console.Write("Select the option : ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0)
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Thank you for using our platform! Hope you have a good day!");
                            return;
                        case 1:
                            manageAddressBooks.CreateANewAddressBook();
                            break;
                        case 2:
                            manageAddressBooks.DisplayAllAddressBooks();
                            break;
                        case 3:
                            AddressBook = manageAddressBooks.SelectAnAddressBook();
                            HomeMenuOfAnAddressBook();
                            break;
                        case 4:
                            manageAddressBooks.SearchThroughDirectories();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option selected.");
                }
            }
        }
        public void HomeMenuOfAnAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Home Menu");
                Console.WriteLine("1. Add an entry to the address book");
                Console.WriteLine("2. Display entries within the address book");
                Console.WriteLine("3. Edit A Contact using Name");
                Console.WriteLine("4. Remove a User by their Name");
                Console.WriteLine("5. View a User by their City or State");
                Console.WriteLine("6. Count Users by their City or State");
                Console.WriteLine("7. Sort the Users by First Name");
                Console.WriteLine("8. Sort the Users by City");
                Console.WriteLine("9. Sort the Users by State");
                Console.WriteLine("10. Sort the Users by ZIP Code");
                Console.WriteLine("11. Save address book to CSV ");
                Console.WriteLine("12. Load address book from CSV ");
                Console.WriteLine("13. Save address book to JSON ");
                Console.WriteLine("14. Load address book from JSON ");
                Console.WriteLine("0. Exit");
                Console.Write("Select the option : ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0)
                {
                    switch(choice)
                    {
                        case 0:
                            Console.WriteLine();
                            return;
                        case 1:
                            AddressBook.AddAContactPerson();
                            break;
                        case 2:
                            AddressBook.DisplayContactsInTheList();
                            break;
                        case 3:
                            AddressBook.EditContactDetailsByName();
                            break;
                        case 4:
                            AddressBook.RemoveAUserByName();
                            break;
                        case 5:
                            AddressBook.SearchThroughContactList();
                            break;
                        case 6:
                            AddressBook.CountUsersFromARegion();
                            break;
                        case 7:
                            AddressBook.SortUsersInAnOrderedManner();
                            break;
                        case 8:
                            AddressBook.SortUsersByCity();
                            break;
                        case 9:
                            AddressBook.SortUsersByState();
                            break;
                        case 10:
                            AddressBook.SortUsersByZip();
                            break;
                        case 11:
                            _ = AddressBook.SaveToCsvAsync();
                            break;
                        case 12:
                            _ = AddressBook.LoadFromCsvAsync();
                            break;
                        case 13:
                            _ = AddressBook.SaveToJsonAsync();
                            break;
                        case 14:
                            _ = AddressBook.LoadFromJsonAsync();
                            break;
                    }
                }
            }
        }
    }
}
