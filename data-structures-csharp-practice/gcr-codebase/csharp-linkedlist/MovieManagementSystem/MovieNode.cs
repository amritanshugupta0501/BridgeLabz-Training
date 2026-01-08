using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.MovieManagementSystem
{
    internal class MovieNode
    {
        public string MovieTitle;
        public string Director;
        public int YearOfRelease;
        public double Rating;
        public MovieNode Next;
        public MovieNode Previous;

        public MovieNode(string title, string director, int year, double rating)
        {
            MovieTitle = title;
            Director = director;
            YearOfRelease = year;
            Rating = rating;
            Next = null;
            Previous = null;
        }
    }
}
