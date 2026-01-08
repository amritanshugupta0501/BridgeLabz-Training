using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TextEditorSystem
{
    internal class TextEditorApplication
    {
        private TextStateNode Head;
        private TextStateNode Tail;
        private TextStateNode CurrentState;
        private int Count;
        private const int MaxHistory = 10;
        public void AddState(string content)
        {
            TextStateNode newNode = new TextStateNode(content);
            if (CurrentState != null && CurrentState.Next != null)
            {
                TextStateNode temp = CurrentState.Next;
                CurrentState.Next = null;
                while (temp != null)
                {
                    Count--;
                    temp = temp.Next;
                }
                Tail = CurrentState;
            }
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                CurrentState = newNode;
                Count = 1;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
                CurrentState = newNode;
                Count++;
            }
            if (Count > MaxHistory)
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
            }
        }
        public void Undo()
        {
            if (CurrentState != null && CurrentState.Previous != null)
            {
                CurrentState = CurrentState.Previous;
            }
        }
        public void Redo()
        {
            if (CurrentState != null && CurrentState.Next != null)
            {
                CurrentState = CurrentState.Next;
            }
        }
        public void DisplayCurrent()
        {
            if (CurrentState != null)
            {
                Console.WriteLine($"Current Text: {CurrentState.Content}");
            }
        }
    }
}
