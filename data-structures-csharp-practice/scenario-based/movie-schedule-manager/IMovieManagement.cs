using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.InventoryManagementSystem
{
    internal interface IMovieManagement
    {
        void AddAMovie();
        void DisplayAllTheMovies();
        void UpdateDetailsOfMovie(string criteria);
        void SearchMovieByTitle(string keyword);
        void SearchMovieByGenre(string keyword);
        void ViewListOfMovies();
        void UpdateAMovie();
        void SearchAMovie();
    }
}
