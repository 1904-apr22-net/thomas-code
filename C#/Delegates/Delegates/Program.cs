using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // var movie = new Movie();
            // movie.Name = "Infinity War";

            var movie = new Movie { Name = "Infinity War" };

            var moviePlayer = new MoviePlayer() { currentMovie = movie };

            //subscribe to the event:

            moviePlayer.Play();
           
        }
    }
}
