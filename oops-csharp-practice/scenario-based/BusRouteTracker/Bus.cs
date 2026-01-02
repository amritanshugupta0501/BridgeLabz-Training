using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.BusRouteTracker
{
    internal class Bus
    {
        int conductorID;
        int driverID;
        public string busNumber;
        int numberOfStops;
        int capacity;
        Passenger[] passengers;											// Array to store the details of passengers
        int currentNumberOfPassengers;
        public string currentStop = "0";
        int passengersLeft;
        int totoalDistanceTravelled = 0;
        public Bus(int conductorID, int driverID, string busNumber, int numberOfStops, int capacity)		// Constructor to define a bus characteristics
        {
            this.conductorID = conductorID;
            this.driverID = driverID;
            this.busNumber = busNumber;
            this.numberOfStops = numberOfStops;
            this.capacity = capacity;
        }
        public void DisplayBusDetails()										// Function to display bus details
        {
            Console.WriteLine("Bus Details:");
            Console.WriteLine("Bus Number: "+busNumber);
            Console.WriteLine("Conductor ID: "+conductorID);
            Console.WriteLine("Driver ID: "+driverID);
            Console.WriteLine("Number of Stops: "+numberOfStops);
            Console.WriteLine("Capacity: "+capacity);
            Console.WriteLine("Current stop of the bus: "+currentStop);
            passengers = new Passenger[capacity];
        }
        Passenger GetPassengerDetails()										// Function to get passenger details in a bus
        {
            Console.WriteLine("Enter passenger name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter passenger id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter passenger contact number: ");
            string contactNumber = Console.ReadLine();
            Passenger passenger = new Passenger(id, name, contactNumber);
            if(passenger.hasTicket)										// Check if the passenger already has a ticket or not
            {
                Console.Write("Ask the stop number the passenger wants to board off : ");
                string stopNumber = Console.ReadLine();
                if(int.TryParse(stopNumber, out int stopNum)&&stopNum >=1 && stopNum <= numberOfStops)		// Check if the entered stop exists in the bus schedule or not
                {
                    passenger.GetTicket(stopNumber);
                    passenger.OnBoard();
                }
                else
                {
                    Console.WriteLine("Invalid stop number. Ticket not issued.");
                }
                passenger = null;
            }
            return passenger;
        }
        public void AddPassengers()										// Function to add passengers in a bus
        {
            bool addingPassengers = true;
            while (addingPassengers)
            {
                string response = "";
                if (currentNumberOfPassengers < capacity)
                {
                    passengers[currentNumberOfPassengers] = GetPassengerDetails();
                    if (passengers[currentNumberOfPassengers] == null)
                    {
                        Console.WriteLine("Passenger not added due to invalid ticket.");
                        return;
                    }
                    currentNumberOfPassengers++;
                    Console.WriteLine("Passenger added. Current number of passengers: " + currentNumberOfPassengers);
                    passengersLeft = currentNumberOfPassengers;
                    Console.WriteLine("Do you want to add more passengers? (yes/no)");
                    response = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Sorry, the bus is full. Cannot add more passengers.");
                    addingPassengers = false;
                }               
                if (response != "yes")
                {
                    addingPassengers = false;
                }
            }
            StartTheBus();											// Function called to again start the journey of the bus

        }
        public void RemovePassengers()										// Function to remove passenger from bus as soon as the stop arrives
        {
            if (currentNumberOfPassengers > 0)
            {
                for (int loop = 0; loop < currentNumberOfPassengers; loop++)					// Loop to traverse through detail of each passenger
                {
                    if (AskPassenger(passengers[loop]))
                    {
                        passengersLeft--;
                        Console.WriteLine("Passenger removed. Current number of passengers: " + passengersLeft);
                    }
                    else
                    {
                        Console.WriteLine("No passengers to remove.");
                    }
                }
            }
            else
            {
                Console.WriteLine("The bus is empty.");
            }
        }
        
        void SetCurrentStop(string stop)									// Function to change the current stop of the bus
        {
            currentStop = stop;
        }
        public void StartTheBus()										// Function to start the bus
        {
            while(int.Parse(currentStop) != numberOfStops)							// Loop to compute that the current stop doesn't exceed number of stops
            {
                Console.WriteLine("Current stop of the bus: "+currentStop);
                RemovePassengers();
                AddPassengers();
                int nextStop = int.Parse(currentStop) + 1;
                currentStop = nextStop.ToString();
                totoalDistanceTravelled += 5;
                Console.WriteLine("The bus is moving to the next stop...");
                
                return;
            }
            Console.WriteLine("The bus has reached the final stop. All Passengers are requested to off board.");
            passengersLeft = 0;
        }
        bool AskPassenger(Passenger passenger)									// Function to ask whether a passenger wants to board down the bus
        {
            if(passenger.stopNumber.Equals(currentStop))
            {
                return true;
            }
            return false;
        }
    }
}
