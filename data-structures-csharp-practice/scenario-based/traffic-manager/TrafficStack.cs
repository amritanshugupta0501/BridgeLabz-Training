using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Scenario_Based.TrafficManager
{
    internal class TrafficStack
    {
        private VehicleNode top;
        public void Push(VehicleInformation v)
        {
            VehicleNode newNode = new VehicleNode(v);
            newNode.Next = top;
            top = newNode;
        }
        public VehicleInformation Pop()
        {
            if (top == null) return null;
            VehicleInformation vehicle = top.Data;
            top = top.Next;
            return vehicle;
        }
        public void DisplayHistory()
        {
            if (top == null)
            {
                Console.WriteLine("  (No cars have exited yet)");
                return;
            }
            VehicleNode current = top;
            while (current != null)
            {
                Console.Write($"{current.Data} | ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
