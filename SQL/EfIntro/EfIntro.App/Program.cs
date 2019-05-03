using EfIntro.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Linq;

namespace EfIntro.App
{
    class Program
    {
        public static readonly LoggerFactory AppLoggerFactory
             = new LoggerFactory(new[] 
             {
                 new ConsoleLoggerProvider((category_, level)
                     => level >= LogLevel.Information, true)
             });
        static void Main(string[] args)
        {
                 using (MovieDbContext dbContext = CreateDbContext())
            {
                PrintMovies(dbContext);

                AddAMovie(dbContext);

                PrintMovies(dbContext);

                UpdateAMovie(dbContext);

                PrintMovies(dbContext);

                DeleteAMovie(dbContext);

                PrintMovies(dbContext);

            }


        }

        private static void DeleteAMovie(MovieDbContext dbContext)
        {
            Movie movie = dbContext.Movie
                 .OrderByDescending(m => m.DateModified)
                 .First();
            dbContext.Remove(movie);
            dbContext.SaveChanges();
        }

        private static void UpdateAMovie(MovieDbContext dbContext)
        {
            Movie movie = dbContext.Movie
                .OrderByDescending(m => m.DateModified)
                .First();
            movie.Active = !movie.Active;
            dbContext.SaveChanges();
        }

        private static void AddAMovie(MovieDbContext dbContext)
        {
            var actionGenre = dbContext.Genre.First(g => g.Name == "Action");

            var movie = new Movie
            {
                Title = "Star Wars VIII",
                ReleaseDate = new DateTime(2018, 1, 1),
                Genre = actionGenre
            };
            dbContext.Movie.Add(movie);
            try
            {
                dbContext.SaveChanges();
            }
           catch (DbUpdateException ex)
            {
                dbContext.Movie.Remove(movie);
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintMovies(MovieDbContext dbContext)
        {
            foreach (var movie in dbContext.Movie.Include(m => m.Genre))
            {
                Console.WriteLine($"{movie.MovieId}: {movie.Title} ({movie.ReleaseDate.Year})");
            }
            Console.WriteLine();
        }

        private static MovieDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();
            optionsBuilder
                .UseSqlServer(SecretConfiguration.ConnectionString)
                .UseLoggerFactory(AppLoggerFactory); //comment this out when presenting project

            return new MovieDbContext(optionsBuilder.Options);
        }
    }
}
