using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.OnlineTicketManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketManagementApplication tickets = new TicketManagementApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ticket Reservation ");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Cancel Ticket");
                Console.WriteLine("3. Display All");
                Console.WriteLine("4. Search Ticket");
                Console.WriteLine("5. Count Tickets");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Customer: "); 
                        string customerName = Console.ReadLine();
                        Console.Write("Movie: "); 
                        string movieName = Console.ReadLine();
                        Console.Write("Seat: "); 
                        string seat = Console.ReadLine();
                        tickets.AddTicket(id, customerName, movieName, seat);
                        break;
                    case "2":
                        Console.Write("Ticket ID: ");
                        id = int.Parse(Console.ReadLine());
                        tickets.RemoveTicket(id);
                        break;
                    case "3":
                        tickets.DisplayTickets();
                        break;
                    case "4":
                        Console.Write("Give either Customer or Movie Name: ");
                        string query = Console.ReadLine();
                        tickets.SearchTicket(query);
                        break;
                    case "5":
                        Console.WriteLine($"Total: {tickets.CountTickets()}");
                        break;
                }
            }
        }
    }
}
