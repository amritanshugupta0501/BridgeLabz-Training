using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Scenario_Based.TrafficManager
{
    internal class TrafficManageList
    {
        private VehicleNode head = null;
        private VehicleNode tail = null;

        public bool IsEmpty() => head == null;

        public void Add(VehicleInformation vehicle)
        {
            VehicleNode newNode = new VehicleNode(vehicle);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.Next = head; // Point to self
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head; // Point back to start
            }
            Console.WriteLine($"ROUNDABOUT: {vehicle} entered the circle.");
        }

        public VehicleInformation RemoveVehicle(string vehicleNumber)
        {
            if (head == null) return null;

            VehicleNode current = head;
            VehicleNode previous = tail;

            do
            {
                if (current.Data.VehicleNumber.Equals(vehicleNumber, StringComparison.OrdinalIgnoreCase))
                {
                    // Found the car, remove it logic:
                    if (current == head && current == tail) // Only 1 node
                    {
                        head = null;
                        tail = null;
                    }
                    else if (current == head) // Remove Head
                    {
                        head = head.Next;
                        tail.Next = head;
                    }
                    else if (current == tail) // Remove Tail
                    {
                        tail = previous;
                        tail.Next = head;
                    }
                    else // Remove Middle
                    {
                        previous.Next = current.Next;
                    }
                    return current.Data;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            return null; // Not found
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("  (Roundabout Empty)");
                return;
            }
            VehicleNode current = head;
            Console.Write("  Flow: ");
            do
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine("(Back to Start)");
        }
    }
}

