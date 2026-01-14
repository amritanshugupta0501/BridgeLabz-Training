using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    // Entry point of the Address Book System Application
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            AddressBookMenu addressBookMenu = new AddressBookMenu();
            addressBookMenu.HomeMenu();
        }
    }
}
