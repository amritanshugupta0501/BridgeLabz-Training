using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.RoundRobinSchedulerSystem
{
    internal class ProcessNode
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public int WaitingTime;
        public int TurnAroundTime;
        public ProcessNode Next;
        public ProcessNode(int id, int burst, int priority)
        {
            ProcessId = id;
            BurstTime = burst;
            RemainingTime = burst;
            Priority = priority;
        }
    }
}
