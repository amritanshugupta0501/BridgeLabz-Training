using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddAContactPerson();
        void DisplayContactsInTheList();
        void EditContactDetailsByName();
        void RemoveAUserByName();
        string AddressBookName1{get; set;}
    }
}
