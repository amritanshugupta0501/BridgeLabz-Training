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
        bool CheckDuplicate(ContactPerson newContact);
        void SearchThroughContactList();
        void CountUsersFromARegion();
        void SortUsersInAnOrderedManner();
        // additional sorts requested by user
        void SortUsersByCity();
        void SortUsersByState();
        void SortUsersByZip();
        // file IO operations (asynchronous to avoid blocking)
        System.Threading.Tasks.Task SaveToCsvAsync();
        System.Threading.Tasks.Task LoadFromCsvAsync();
        System.Threading.Tasks.Task SaveToJsonAsync();
        System.Threading.Tasks.Task LoadFromJsonAsync();
    }
}
