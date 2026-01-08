using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.RoundRobinSchedulerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoundRobinSchedulerApplication scheduler = new RoundRobinSchedulerApplication();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Round Robin Scheduler ");
                Console.WriteLine("1. Add Process");
                Console.WriteLine("2. Simulate");
                Console.WriteLine("0. Back");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Console.Write("Process ID: "); 
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Burst Time: "); 
                        int burst = int.Parse(Console.ReadLine());
                        Console.Write("Priority: "); 
                        int prio = int.Parse(Console.ReadLine());
                        scheduler.AddProcess(id, burst, prio);
                        break;
                    case "2":
                        Console.Write("Time Quantum: "); 
                        int tq = int.Parse(Console.ReadLine());
                        scheduler.Simulate(tq);
                        break;
                }
            }
        }
    }
}
