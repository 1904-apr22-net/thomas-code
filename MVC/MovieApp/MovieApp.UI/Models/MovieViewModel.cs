using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.UI.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateReleased {get; set;}
    public GenreViewModel Genre { get; set; }

    }
}
