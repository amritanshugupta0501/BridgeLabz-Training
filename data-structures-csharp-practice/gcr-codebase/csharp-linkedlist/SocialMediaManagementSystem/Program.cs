using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.SocialMediaManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMediaNetworkApplication socialMedia = new SocialMediaNetworkApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Social Network");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Connection");
                Console.WriteLine("3. Remove Connection");
                Console.WriteLine("4. Find Mutual Friends");
                Console.WriteLine("5. Display Friends");
                Console.WriteLine("6. Count Friends");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write("ID: "); 
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: "); 
                        string name = Console.ReadLine();
                        Console.Write("Age: "); 
                        int age = int.Parse(Console.ReadLine());
                        socialMedia.AddUser(id, name, age);
                        break;
                    case "2":
                        Console.Write("User 1 ID: "); 
                        int user1 = int.Parse(Console.ReadLine());
                        Console.Write("User 2 ID: "); 
                        int user2 = int.Parse(Console.ReadLine());
                        socialMedia.AddFriendConnection(user1, user2);
                        break;
                    case "3":
                        Console.Write("User 1 ID: "); 
                        user1 = int.Parse(Console.ReadLine());
                        Console.Write("User 2 ID: "); 
                        user2 = int.Parse(Console.ReadLine());
                        socialMedia.RemoveFriendConnection(user1, user2);
                        break;
                    case "4":
                        Console.Write("User 1 ID: "); 
                        user1 = int.Parse(Console.ReadLine());
                        Console.Write("User 2 ID: ");
                        user2 = int.Parse(Console.ReadLine());
                        socialMedia.FindMutualFriends(user1, user2);
                        break;
                    case "5":
                        Console.Write("User ID: ");
                        user1 = int.Parse(Console.ReadLine());
                        socialMedia.DisplayFriends(user1);
                        break;
                    case "6":
                        socialMedia.CountFriends();
                        break;
                }
            }
        }
    }
}
