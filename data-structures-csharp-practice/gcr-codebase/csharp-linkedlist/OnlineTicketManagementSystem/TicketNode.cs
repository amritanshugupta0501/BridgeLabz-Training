using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.OnlineTicketManagementSystem
{
    internal class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;
        public TicketNode(int id, string customer, string movie, string seat)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }
}
