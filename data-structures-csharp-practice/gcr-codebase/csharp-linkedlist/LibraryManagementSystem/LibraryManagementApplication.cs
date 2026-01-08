using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.LibraryManagementSystem
{
    internal class LibraryManagementApplication
    {
        private BookNode Head;
        public void AddBook(int id, string title, string author, string genre, bool available)
        {
            BookNode newNode = new BookNode(id, title, author, genre, available);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            BookNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Previous = current;
        }
        public void RemoveBook(int id)
        {
            if (Head == null) return;
            BookNode current = Head;
            while (current != null && current.BookId != id)
            {
                current = current.Next;
            }
            if (current == null) return;

            if (current.Previous != null)
                current.Previous.Next = current.Next;
            else
                Head = current.Next;

            if (current.Next != null)
                current.Next.Previous = current.Previous;
        }
        public void SearchBook(string query)
        {
            BookNode current = Head;
            while (current != null)
            {
                if (current.BookTitle == query || current.Author == query)
                {
                    Console.WriteLine($"Found: {current.BookTitle} by {current.Author}");
                }
                current = current.Next;
            }
        }
        public void UpdateAvailability(int id, bool status)
        {
            BookNode current = Head;
            while (current != null)
            {
                if (current.BookId == id)
                {
                    current.IsAvailable = status;
                    return;
                }
                current = current.Next;
            }
        }
        public void DisplayBooks(bool reverse)
        {
            if (Head == null) return;
            if (!reverse)
            {
                BookNode current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.BookTitle);
                    current = current.Next;
                }
            }
            else
            {
                BookNode current = Head;
                while (current.Next != null) current = current.Next;
                while (current != null)
                {
                    Console.WriteLine(current.BookTitle);
                    current = current.Previous;
                }
            }
        }
        public int CountBooks()
        {
            int count = 0;
            BookNode current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
