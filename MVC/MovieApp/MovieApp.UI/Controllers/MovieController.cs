using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.BL;
using MovieApp.UI.Models;

namespace MovieApp.UI.Controllers
{
    public class MovieController : Controller
    {
        // ASP.NET heavily supports/encourages dependency injection.
        public IMovieRepository MovieRepo { get; set; }

        public MovieController(IMovieRepository movieRepo)
        {
            MovieRepo = movieRepo ?? throw new ArgumentNullException(nameof(movieRepo));
        }

        public IActionResult Index()
        {
            var movies = MovieRepo.GetAll();

            var model = movies.Select(m => new MovieViewModel
            {
                Id = m.Id,
                Title = m.Title,
                DateReleased = m.ReleaseDate,
                Genre = m.Genre
            });

            return View(model);
        }

        public IActionResult Create()
        {
            var viewModel = new MovieViewModel
            {
                Genres = MovieRepo.GetAllGenres().ToList()
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieViewModel viewModel)
        {
            if (viewModel.Title == "Star Wars: The Last Jedi")
            {
                ModelState.AddModelError("Title", "The movie was bad");

                ModelState.AddModelError("", "There were some errors");
            }

            Genre genre = null;
            if (viewModel.Genre != null)
            {
                genre = MovieRepo.GetGenreById(viewModel.Genre.Id);
                if (genre == null)
                {
                    ModelState.AddModelError("Genre", "Invalid genre ID");
                }
            }

            if (!ModelState.IsValid)
            {
                viewModel.Genres = MovieRepo.GetAllGenres().ToList();
                return View(viewModel);
            }
            var movie = new Movie
            {
                Title = viewModel.Title,
                ReleaseDate = viewModel.DateReleased,
                Genre = genre
            };
            MovieRepo.Create(movie);
            return RedirectToAction("Index");
        }
    }
}