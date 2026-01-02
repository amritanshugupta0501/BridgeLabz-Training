using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BusRouteTracker
{
    internal class Passenger
    {
        int passengerID;
        private string passengerName;
        private string contactNumber;
        public string stopNumber;
        public bool hasTicket=false;
        bool onBoard=false;
        public Passenger(int passengerID, string passengerName, string contactNumber)			// Constructor to initialize the characteristics of a passenger
        {
            this.passengerID = passengerID;
            this.passengerName = passengerName;
            this.contactNumber = contactNumber;

        }
        public void GetTicket(string stopNumber)							// Function to get the passenger a ticket
        {
            this.stopNumber = stopNumber;
            this.hasTicket = true;
        }
        public void OnBoard()										// Function to check if the passenger is on-board or not
        {
            this.onBoard = true;
        }
        void OffBoarded()										// Function to check if the passenger has boarded off the bus or not
        {
            this.onBoard = false;
        }
        void DisplayPassengerDetails()									// Function to view the details of a passenger
        {
            Console.WriteLine("Passenger Details:");
            Console.WriteLine("Passenger ID: "+passengerID);
            Console.WriteLine("Passenger Name: "+passengerName);
            Console.WriteLine("Contact Number: "+contactNumber);
            Console.WriteLine("Stop Number: "+stopNumber);
            Console.WriteLine("Has Ticket: "+hasTicket);
            Console.WriteLine("On Board: "+onBoard);
        }
    }
}
