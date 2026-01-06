using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.bird_sanctuary
{
    internal sealed class Menu
    {
        private Bird[] sanctuary;
        private int birdCount;                                                      // Tracks how many birds are currently in the array
        private int maxCapacity;

        public Menu(int capacity)
        {
            maxCapacity = capacity;
            sanctuary = new Bird[maxCapacity];
            birdCount = 0;
        }

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\tEcoWing Wildlife Conservation Center ");
                Console.WriteLine($"Capacity: {birdCount}/{maxCapacity}");
                Console.WriteLine("1. Add a Bird");
                Console.WriteLine("2. Track All Birds ");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBird();
                        break;
                    case "2":
                        ListBirds();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void AddBird()
        {
            if (birdCount >= maxCapacity)
            {
                Console.WriteLine("\nSanctuary is full! Cannot add more birds.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n--- Add a New Bird ---");
            Console.WriteLine("1. Eagle (Flies)");
            Console.WriteLine("2. Sparrow (Flies)");
            Console.WriteLine("3. Duck (Swims)");
            Console.WriteLine("4. Penguin (Swims)");
            Console.WriteLine("5. Seagull (Flies & Swims)");
            Console.Write("Choose bird type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))                      // Simple validation
            {
                Console.Write("Invalid number. Enter Age: ");
            }

            Bird newBird = null;

            switch (type)
            {
                case "1": newBird = new Eagle(name, age); break;
                case "2": newBird = new Sparrow(name, age); break;
                case "3": newBird = new Duck(name, age); break;
                case "4": newBird = new Penguin(name, age); break;
                case "5": newBird = new Seagull(name, age); break;
                default:
                    Console.WriteLine("Invalid bird type selected.");
                    Console.ReadLine();
                    return;
            }
            sanctuary[birdCount] = newBird;                                         // Add to Array and increment counter
            birdCount++;

            Console.WriteLine($"Successfully added {name}!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private void ListBirds()
        {
            Console.Clear();
            Console.WriteLine("--- Daily Tracking Log ---");

            if (birdCount == 0)
            {
                Console.WriteLine("No birds in the sanctuary yet.");
            }
            else
            {
                for (int i = 0; i < birdCount; i++)                                 // Iterate only up to birdCount (not the empty spots in the array)
                {
                    Bird bird = sanctuary[i];
                    Console.WriteLine(bird.ToString());
                    bird.Eat();
                    if (bird is IFlyable flyer)                                     // Polymorphism & Pattern Matching
                    {
                        flyer.Fly();
                    }

                    if (bird is ISwimmable swimmer)
                    {
                        swimmer.Swim();
                    }
                }
            }
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    }
}
