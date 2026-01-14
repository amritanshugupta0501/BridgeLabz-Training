using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBookSystem
{
    internal interface IAddressBookManager
    {
        void CreateANewAddressBook();
        void DisplayAllAddressBooks();
        IAddressBook SelectAnAddressBook();
    }
}
