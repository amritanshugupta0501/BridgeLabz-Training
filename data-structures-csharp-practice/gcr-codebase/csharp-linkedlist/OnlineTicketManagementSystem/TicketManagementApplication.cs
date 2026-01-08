using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.OnlineTicketManagementSystem
{
    internal class TicketManagementApplication
    {
        private TicketNode Head;
        public void AddTicket(int id, string customer, string movie, string seat)
        {
            TicketNode newNode = new TicketNode(id, customer, movie, seat);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
            }
            else
            {
                TicketNode current = Head;
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Next = Head;
            }
        }
        public void RemoveTicket(int id)
        {
            if (Head == null) return;

            if (Head.TicketId == id && Head.Next == Head)
            {
                Head = null;
                return;
            }
            TicketNode current = Head;
            TicketNode prev = null;
            if (Head.TicketId == id)
            {
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = Head.Next;
                Head = Head.Next;
                return;
            }
            current = Head;
            while (current.Next != Head && current.TicketId != id)
            {
                prev = current;
                current = current.Next;
            }
            if (current.TicketId == id)
            {
                prev.Next = current.Next;
            }
        }
        public void DisplayTickets()
        {
            if (Head == null) return;
            TicketNode current = Head;
            do
            {
                Console.WriteLine($"Ticket: {current.TicketId}, {current.CustomerName}, {current.MovieName}");
                current = current.Next;
            } while (current != Head);
        }
        public void SearchTicket(string query)
        {
            if (Head == null) return;
            TicketNode current = Head;
            do
            {
                if (current.CustomerName == query || current.MovieName == query)
                {
                    Console.WriteLine($"Found Ticket ID: {current.TicketId} for {current.CustomerName}");
                }
                current = current.Next;
            } while (current != Head);
        }
        public int CountTickets()
        {
            if (Head == null) return 0;
            int count = 0;
            TicketNode current = Head;
            do
            {
                count++;
                current = current.Next;
            } while (current != Head);
            return count;
        }
    }
}
