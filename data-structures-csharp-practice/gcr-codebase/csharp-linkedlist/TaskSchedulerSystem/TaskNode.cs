using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TaskSchedulerSystem
{
    internal class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;  

        public TaskNode(int id, string name, int priority, DateTime date)
        {
            TaskId = id;
            TaskName = name;
            Priority = priority;
            DueDate = date;
            Next = null;
        }
    }
}
