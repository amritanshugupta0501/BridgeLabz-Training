using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.MovieManagementSystem
{
    internal class MovieManagementApplication
    {
        private MovieNode Head;
        public MovieManagementApplication() 
        {
            Head = null;
        }

        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (Head != null)
            {
                Head.Previous = newNode;
                newNode.Next = Head;
            }
            Head = newNode;
        }

        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            MovieNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Previous = current;
        }

        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position < 1) return;
            if (position == 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            MovieNode current = Head;
            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null) return;

            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = current.Next;
            newNode.Previous = current;

            if (current.Next != null)
            {
                current.Next.Previous = newNode;
            }
            current.Next = newNode;
        }

        public void RemoveByTitle(string title)
        {
            if (Head == null) return;

            MovieNode current = Head;
            while (current != null && current.MovieTitle != title)
            {
                current = current.Next;
            }

            if (current == null) return;

            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                Head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
        }

        public void SearchByDirector(string director)
        {
            MovieNode current = Head;
            while (current != null)
            {
                if (current.Director == director)
                    Console.WriteLine(current.MovieTitle);
                current = current.Next;
            }
        }

        public void SearchByRating(double rating)
        {
            MovieNode current = Head;
            while (current != null)
            {
                if (current.Rating == rating)
                    Console.WriteLine(current.MovieTitle);
                current = current.Next;
            }
        }

        public void DisplayForward()
        {
            MovieNode current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.MovieTitle} - {current.Director}");
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            if (Head == null) return;
            MovieNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            while (current != null)
            {
                Console.WriteLine($"{current.MovieTitle} - {current.Director}");
                current = current.Previous;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            MovieNode current = Head;
            while (current != null)
            {
                if (current.MovieTitle == title)
                {
                    current.Rating = newRating;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
