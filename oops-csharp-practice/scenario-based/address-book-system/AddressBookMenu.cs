using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    sealed class AddressBookMenu
    {
        private IAddressBook AddressBook;
        public void HomeMenu()
        {
            AddressBook = new AddressBookUtilityImpl();
            Console.WriteLine("Welcome to Address Book System Application!");
            while (true)
            {
                Console.WriteLine("Home Menu");
                Console.WriteLine("1. Add an entry to the address book");
                Console.WriteLine("2. Display entries within the address book");
                Console.WriteLine("3. Edit A Contact using Name");
                Console.WriteLine("4. Remove a User by their Name");
                Console.WriteLine("0. Exit");
                Console.Write("Select the option : ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0)
                {
                    switch(choice)
                    {
                        case 0:
                            Console.WriteLine("Thank you for using our platform! Hope you have a good day!");
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
                    }
                }
            }
        }
    }
}
