using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.LibraryManagementSystem
{
    internal interface IReservable
    {
        void ReserveItem(string borrower);
        bool CheckAvailability();
    }
}
