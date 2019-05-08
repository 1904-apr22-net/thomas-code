using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.BL
{
    interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        void Create(Movie movie);
    }
}
