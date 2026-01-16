using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Scenario_Based.TrafficManager
{
    // Class to manage the waiting queue of the traffic
    internal class TrafficQueue
    {
        private VehicleNode Front;
        private VehicleNode Rear;
        public int Count { get; private set; }
        public int MaxCapacity { get; private set; }
        // Constructor initialized to initialize the maximum capacity of the Queue to hold traffic
        public TrafficQueue(int capacity)
        {
            Front = null;
            Rear = null;
            Count = 0;
            MaxCapacity = capacity;
        }
        // Function to check if the waiting queue is full or not i.e. Overflow condition check
        public bool IsFull()
        {
            return Count >= MaxCapacity;
        }
        // Function to check if the waiting queue is empty or not i.e. Underflow condition check
        public bool IsEmpty()
        {
            return Count == 0;
        }
        // Function to enter the vehicle into the queue
        public void Enqueue(VehicleInformation vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine($"OVERFLOW: Queue is full. {vehicle} cannot enter.");
                return;
            }
            VehicleNode newNode = new VehicleNode(vehicle);
            if (Rear == null)
            {
                Front = newNode;
                Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
            Count++;
            Console.WriteLine($"QUEUED: {vehicle} added to waiting line.");
        }
        // Function to exit the vehicle out of the queue
        public VehicleInformation Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("UNDERFLOW: Queue is empty.");
                return null;
            }
            VehicleInformation temp = Front.Data;
            Front = Front.Next;
            if (Front == null)
            {
                Rear = null;
            }
            Count--;
            return temp;
        }
        // Function to display the traffic queue status
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("  (Queue Empty)");
                return;
            }
            VehicleNode current = Front;
            while (current != null)
            {
                Console.WriteLine($"{current.Data}");
                current = current.Next;
            }
        }
    }
}
