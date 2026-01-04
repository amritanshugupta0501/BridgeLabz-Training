using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.inheritance
{
    // Base class
    internal class TransportUnit
    {
        public int TopSpeed;
        public string PowerSource;

        // Constructor
        public TransportUnit(int speed, string source)
        {
            TopSpeed = speed;
            PowerSource = source;
        }

        // Virtual method
        public virtual void ShowSpecs()
        {
            Console.WriteLine($"Top Velocity : {TopSpeed} km/h");
            Console.WriteLine($"Energy       : {PowerSource}");
        }
    }

    // Car subclass renamed to Sedan
    class Sedan : TransportUnit
    {
        public int PassengerLimit;

        public Sedan(int speed, string source, int passengers)
            : base(speed, source)
        {
            PassengerLimit = passengers;
        }

        public override void ShowSpecs()
        {
            base.ShowSpecs();
            Console.WriteLine($"Passengers   : {PassengerLimit}");
        }
    }

    // Truck subclass renamed to Lorry
    class Lorry : TransportUnit
    {
        public int LoadLimit;

        public Lorry(int speed, string source, int load)
            : base(speed, source)
        {
            LoadLimit = load;
        }

        public override void ShowSpecs()
        {
            base.ShowSpecs();
            Console.WriteLine($"Cargo Limit  : {LoadLimit} kg");
        }
    }

    // Motorcycle subclass renamed to Bike
    class Bike : TransportUnit
    {
        public bool IsSidecarAttached;

        public Bike(int speed, string source, bool sidecar)
            : base(speed, source)
        {
            IsSidecarAttached = sidecar;
        }

        public override void ShowSpecs()
        {
            base.ShowSpecs();
            Console.WriteLine($"Has Sidecar  : {IsSidecarAttached}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Array of TransportUnit type (polymorphism)
            TransportUnit[] fleet =
            {
                new Sedan(180, "Petrol", 5),
                new Lorry(120, "Diesel", 5000),
                new Bike(150, "Petrol", false)
            };

            // Dynamic method dispatch
            foreach (TransportUnit t in fleet)
            {
                t.ShowSpecs();
                Console.WriteLine();
            }
        }
    }
}