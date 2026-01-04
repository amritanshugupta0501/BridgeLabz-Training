using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class HotelBookingSystem
    {
        string guestName;
        string roomType;
        int nights;
        public HotelBookingSystem()
        {
            guestName = "John";
            roomType = "Single-Sized";
            nights = 1;
        }
        public HotelBookingSystem(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }
        public HotelBookingSystem(HotelBookingSystem hotel)
        {
            this.guestName = hotel.guestName;
            this.roomType = hotel.roomType;
            this.nights = hotel.nights;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Guest Name : " + guestName);
            Console.WriteLine("Room type : " + roomType);
            Console.WriteLine("Number of nights rented : " + nights);
        }
    }
    class Program
    {
        static void Main()
        {
            HotelBookingSystem room1 = new HotelBookingSystem();
            room1.DisplayDetails();
            Console.WriteLine();
            Console.Write("Give the guest Name : ");
            string name = Console.ReadLine();
            Console.Write("Give the room type : ");
            string room = Console.ReadLine();
            Console.Write("Number of nights : ");
            int nights = int.Parse(Console.ReadLine());
            HotelBookingSystem room2 = new HotelBookingSystem(name, room, nights);
            room2.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Copy constructor");
            HotelBookingSystem room3 = new HotelBookingSystem(room1);
            room3.DisplayDetails();

        }
    }
}
