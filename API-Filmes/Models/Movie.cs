using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Filmes.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "Film must have a title")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        [Range(1, 600, ErrorMessage = "Film lenght exceed maximum of 600 minutes")]
        public int Lenght { get; set; }
    }
}
