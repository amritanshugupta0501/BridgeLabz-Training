using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.LibraryManagementSystem
{
    internal class Book : LibraryItem, IReservable
    {
        private bool IsReserved;
        private string ReservedBy;

        public Book(string itemId, string title, string author)
            : base(itemId, title, author)
        {
            IsReserved = false;
        }

        public override int GetLoanDuration()
        {
            return 14;
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
