using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryItem[] libraryInventory = new LibraryItem[]
            {
            new Book("B-101", "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine("M-202", "Tech Monthly", "TechWorld Inc."),
            new DVD("D-303", "Inception", "Christopher Nolan")
            };

            ProcessLibraryItems(libraryInventory);
        }

        public static void ProcessLibraryItems(LibraryItem[] items)
        {
            Console.WriteLine("Library Inventory Status...\n");

            foreach (LibraryItem item in items)
            {
                Console.WriteLine(item.GetItemDetails());
                Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

                if (item is IReservable)
                {
                    IReservable reservableItem = (IReservable)item;
                    bool isAvailable = reservableItem.CheckAvailability();

                    if (isAvailable)
                    {
                        Console.WriteLine("Status: Available");
                        reservableItem.ReserveItem("John Doe");
                        Console.WriteLine("Action: Reserved for John Doe");
                    }
                    else
                    {
                        Console.WriteLine("Status: Checked Out / Reserved");
                    }
                }
            }
        }
    }
}
