using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.DA
{
    class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _data;

       public MovieRepository(List<Movie> data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public IEnumerable<Movie> GetAll()
        {
            return _data;
        }

        public IEnumerable<Movie>

    }
}
