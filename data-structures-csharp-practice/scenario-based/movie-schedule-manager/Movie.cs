using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.movie_schedule_manager
{
    // Node class for a linked list
    internal class Movie
    {
        private string MovieTitle;
        private string MovieDirector;
        private string MovieGenre;
        private string MovieHours;
        private string MovieShowTiming;
        public Movie Next;

        public string MovieTitle1 { get => MovieTitle; set => MovieTitle = value; }
        public string MovieDirector1 { get => MovieDirector; set => MovieDirector = value; }
        public string MovieGenre1 { get => MovieGenre; set => MovieGenre = value; }
        public string MovieHours1 { get => MovieHours; set => MovieHours = value; }
        public string MovieShowTiming1 { get => MovieShowTiming; set => MovieShowTiming = value; }

        public Movie(string movieTitle, string movieDirector, string movieGenre, string movieHours, string movieShowTiming)
        {
            MovieTitle = movieTitle;
            MovieDirector = movieDirector;
            MovieGenre = movieGenre;
            MovieHours = movieHours;
            MovieShowTiming = movieShowTiming;
            Next = null;
        }
        public override string? ToString()
        {
            return $"Movie Title : {MovieTitle}\nMovie Director : {MovieDirector}\nMovie Genre : {MovieGenre}\nMovie Hours : {MovieHours}\nShow Timings : {MovieShowTiming}\n";
        }
    }
}
