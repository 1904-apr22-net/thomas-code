using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MovieApp.BL;

namespace MovieApp.DA
{
    public class MovieRepository : IMovieRepository
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

        public IEnumerable<Genre> GetAllGenres()
        {
            return _data.Select(m => m.Genre).OrderBy(g => g.Id);
        }

        public Genre GetGenreById(int id)
        {
            return GetAllGenres().FirstOrDefault(g => g.Id == id);
        }

        public void Create(Movie movie)
        {
            var id = _data.Max(x => x.Id) + 1;
            movie.Id = id;
            _data.Add(movie);
        }

    }
}
