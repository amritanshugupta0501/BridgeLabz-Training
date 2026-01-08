using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.LibraryManagementSystem
{
    internal class BookNode
    {
        public int BookId;
        public string BookTitle;
        public string Author;
        public string Genre;
        public bool IsAvailable;
        public BookNode Next;
        public BookNode Previous;

        public BookNode(int id, string title, string author, string genre, bool available)
        {
            BookId = id;
            BookTitle = title;
            Author = author;
            Genre = genre;
            IsAvailable = available;
        }
    }
}
