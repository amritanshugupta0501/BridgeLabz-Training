using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TaskSchedulerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskSchedulerApplication scheduler = new TaskSchedulerApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Task Scheduler ");
                Console.WriteLine("1. Add Task (Beginning)");
                Console.WriteLine("2. Add Task (End)");
                Console.WriteLine("3. Add Task (Position)");
                Console.WriteLine("4. Remove by ID");
                Console.WriteLine("5. View Current & Move Next");
                Console.WriteLine("6. Display All");
                Console.WriteLine("7. Search by Priority");
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
                        Console.Write("Priority: "); 
                        int priority = int.Parse(Console.ReadLine());
                        scheduler.AddAtBeginning(id, name, priority, DateTime.Now.AddDays(1));
                        break;
                    case "2":
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Priority: ");
                        priority = int.Parse(Console.ReadLine());
                        scheduler.AddAtEnd(id, name, priority, DateTime.Now.AddDays(1));
                        break;
                    case "3":
                        Console.Write("Position: "); 
                        int pos = int.Parse(Console.ReadLine());
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Priority: ");
                        priority = int.Parse(Console.ReadLine());
                        scheduler.AddAtPosition(pos, id, name, priority, DateTime.Now.AddDays(1));
                        break;
                    case "4":
                        Console.Write("ID to Remove: ");
                        id = int.Parse(Console.ReadLine());
                        scheduler.RemoveByTaskId(id);
                        break;
                    case "5":
                        scheduler.ViewCurrentAndMove();
                        break;
                    case "6":
                        scheduler.DisplayAll();
                        break;
                    case "7":
                        Console.Write("Priority: ");
                        priority = int.Parse(Console.ReadLine());
                        scheduler.SearchByPriority(priority);
                        break;
                }
            }
        }
    }
}
