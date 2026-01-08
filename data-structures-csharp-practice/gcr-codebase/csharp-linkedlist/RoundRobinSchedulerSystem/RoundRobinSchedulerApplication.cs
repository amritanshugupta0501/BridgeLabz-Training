using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.RoundRobinSchedulerSystem
{
    internal class RoundRobinSchedulerApplication
    {
        private ProcessNode Head;
        public void AddProcess(int id, int burst, int priority)
        {
            ProcessNode newNode = new ProcessNode(id, burst, priority);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
            }
            else
            {
                ProcessNode current = Head;
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Next = Head;
            }
        }
        public void Simulate(int timeQuantum)
        {
            if (Head == null) return;
            int currentTime = 0;
            bool allDone = false;
            while (!allDone)
            {
                allDone = true;
                ProcessNode current = Head;
                do
                {
                    if (current.RemainingTime > 0)
                    {
                        allDone = false;
                        if (current.RemainingTime > timeQuantum)
                        {
                            currentTime += timeQuantum;
                            current.RemainingTime -= timeQuantum;
                        }
                        else
                        {
                            currentTime += current.RemainingTime;
                            current.WaitingTime = currentTime - current.BurstTime;
                            current.RemainingTime = 0;
                            current.TurnAroundTime = currentTime;
                        }
                    }
                    current = current.Next;
                } while (current != Head);

                DisplayProcesses();
            }
            CalculateStats();
        }
        public void DisplayProcesses()
        {
            if (Head == null) return;
            ProcessNode current = Head;
            do
            {
                Console.Write($"P{current.ProcessId}({current.RemainingTime}) -> ");
                current = current.Next;
            } while (current != Head);
            Console.WriteLine("Head");
        }
        public void CalculateStats()
        {
            if (Head == null) return;
            double totalWait = 0;
            double totalTurnAround = 0;
            int count = 0;
            ProcessNode current = Head;
            do
            {
                totalWait += current.WaitingTime;
                totalTurnAround += current.TurnAroundTime;
                count++;
                current = current.Next;
            } while (current != Head);
            Console.WriteLine($"Average Waiting Time: {totalWait / count}");
            Console.WriteLine($"Average Turn Around Time: {totalTurnAround / count}");
        }
    }
}
