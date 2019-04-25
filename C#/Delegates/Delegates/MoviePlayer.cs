using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    class MoviePlayer
    {
        public Movie currentMovie { get; set; }

        //movie player will allow other classes to subscribe to its PlayFinished event
        //using some event handler

        //first we define the type of the event handler
        public delegate void PlayFinishedHandler();
        // it is a "delegate" type, which is, 

        public event PlayFinishedHandler PlayFinished;

        public void Play()
        {

            //Console.WriteLine("Playiing inserted movie" + currentMovie.Name);

            Console.WriteLine($"Playing inserted movie { currentMovie.Name}");

            Thread.Sleep(3000); //wait 3 seconds
        }
    }
}
