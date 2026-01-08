using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TaskSchedulerSystem
{
    internal class TaskSchedulerApplication
    {
        private TaskNode Head;
        private TaskNode CurrentTask;

        public void AddAtBeginning(int id, string name, int priority, DateTime date)
        {
            TaskNode newNode = new TaskNode(id, name, priority, date);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                CurrentTask = Head;
            }
            else
            {
                TaskNode current = Head;
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                newNode.Next = Head;
                current.Next = newNode;
                Head = newNode;
            }
        }

        public void AddAtEnd(int id, string name, int priority, DateTime date)
        {
            TaskNode newNode = new TaskNode(id, name, priority, date);
            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                CurrentTask = Head;
            }
            else
            {
                TaskNode current = Head;
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Next = Head;
            }
        }

        public void AddAtPosition(int position, int id, string name, int priority, DateTime date)
        {
            if (position < 1) return;
            if (position == 1)
            {
                AddAtBeginning(id, name, priority, date);
                return;
            }

            TaskNode newNode = new TaskNode(id, name, priority, date);
            TaskNode current = Head;
            for (int i = 1; i < position - 1 && current.Next != Head; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void RemoveByTaskId(int id)
        {
            if (Head == null) return;

            if (Head.TaskId == id && Head.Next == Head)
            {
                Head = null;
                CurrentTask = null;
                return;
            }

            TaskNode current = Head;
            TaskNode prev = null;

            if (Head.TaskId == id)
            {
                while (current.Next != Head)
                {
                    current = current.Next;
                }
                current.Next = Head.Next;
                Head = Head.Next;
                if (CurrentTask.TaskId == id) CurrentTask = Head;
                return;
            }

            current = Head;
            while (current.Next != Head && current.TaskId != id)
            {
                prev = current;
                current = current.Next;
            }

            if (current.TaskId == id)
            {
                prev.Next = current.Next;
                if (CurrentTask == current) CurrentTask = prev.Next;
            }
        }

        public void ViewCurrentAndMove()
        {
            if (CurrentTask != null)
            {
                Console.WriteLine($"Current Task: {CurrentTask.TaskName}");
                CurrentTask = CurrentTask.Next;
            }
        }

        public void DisplayAll()
        {
            if (Head == null) return;
            TaskNode current = Head;
            do
            {
                Console.WriteLine($"ID: {current.TaskId}, Name: {current.TaskName}");
                current = current.Next;
            } while (current != Head);
        }

        public void SearchByPriority(int priority)
        {
            if (Head == null) return;
            TaskNode current = Head;
            do
            {
                if (current.Priority == priority)
                    Console.WriteLine($"Found: {current.TaskName}");
                current = current.Next;
            } while (current != Head);
        }
    }
}
