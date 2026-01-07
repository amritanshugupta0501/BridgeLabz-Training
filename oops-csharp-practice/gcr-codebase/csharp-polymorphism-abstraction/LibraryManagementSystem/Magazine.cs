using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.LibraryManagementSystem
{
    internal class Magazine : LibraryItem, IReservable
    {
        private bool IsReserved;
        private string ReservedBy;

        public Magazine(string itemId, string title, string author)
            : base(itemId, title, author)
        {
            IsReserved = false;
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem(string borrower)
        {
            IsReserved = true;
            ReservedBy = borrower;
        }

        public bool CheckAvailability()
        {
            return !IsReserved;
        }
    }
}
