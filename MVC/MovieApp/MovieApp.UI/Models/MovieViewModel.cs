using MovieApp.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.UI.Models
{
    public class MovieViewModel
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]

        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime DateReleased {get; set;}

        [Required]
        public Genre Genre { get; set; }

        public List<Genre> Genres { get; set; }

    }
}
