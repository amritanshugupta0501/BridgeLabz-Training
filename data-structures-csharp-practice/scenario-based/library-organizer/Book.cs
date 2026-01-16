using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.libraryorganizer
{
    // Book class defined to assign characteristics to a book
    internal class Book
    {
        private string BookTitle;
        private string BookAuthor;
        private string BookGenres;
        private bool BookAvailability;
        private string BookRentalPrice;
        public Book Next;
        public string BookTitle1 { get => BookTitle; set => BookTitle = value; }
        public string BookAuthor1 { get => BookAuthor; set => BookAuthor = value; }
        public string BookGenres1 { get => BookGenres; set => BookGenres = value; }
        public bool BookAvailability1 { get => BookAvailability; set => BookAvailability = value; }
        public string BookRentalPrice1 { get => BookRentalPrice; set => BookRentalPrice = value; }
        public Book(string bookTitle, string bookAuthor, string bookGenres, bool bookAvailability, string bookRentalPrice)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookGenres = bookGenres;
            BookAvailability = bookAvailability;
            BookRentalPrice = bookRentalPrice;
            Next = null;
        }

        public override string? ToString()
        {
            return $"Book Title : {BookTitle}\nBook Author : {BookAuthor}\nBook Genres : {BookGenres}\n" +
                $"Book Availability Status : {BookAvailability}\nBook Rental Price : {BookRentalPrice}";
        }
    }
}