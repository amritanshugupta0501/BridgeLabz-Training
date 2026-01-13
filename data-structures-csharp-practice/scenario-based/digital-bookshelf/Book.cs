using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.digital_bookshelf
{
    internal class Book
    {
        private string BookDetail;
        public Book Next;

        public string BookDetail1 { get => BookDetail; set => BookDetail = value; }

        public Book(string bookDetail)
        {
            BookDetail = bookDetail;
            Next = null;
        }
    }
}
