using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.polymorphismabstraction.LibraryManagementSystem
{
    internal abstract class LibraryItem
    {
        private string ItemId;
        private string Title;
        private string Author;

        public LibraryItem(string itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        public string GetItemId()
        {
            return ItemId;
        }

        public void SetItemId(string itemId)
        {
            ItemId = itemId;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetItemDetails()
        {
            return "ID: " + ItemId + ", Title: " + Title + ", Author: " + Author;
        }

        public abstract int GetLoanDuration();
    }
}
