using EfIntro.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfIntro.App
{
    class Program
    {
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
            throw new NotImplementedException();
        }

        private static void UpdateAMovie(MovieDbContext dbContext)
        {
            throw new NotImplementedException();
        }

        private static void AddAMovie(MovieDbContext dbContext)
        {
            throw new NotImplementedException();
        }

        private static void PrintMovies(MovieDbContext dbContext)
        {
            foreach (var movie in dbContext.Movie)
            {
                Console.WriteLine($"{movie.MovieId}: {movie.Title} ({movie.ReleaseDate.Year})");
            }
            Console.WriteLine();
        }

        private static MovieDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
            return new MovieDbContext(optionsBuilder.Options);
        }
    }
}
