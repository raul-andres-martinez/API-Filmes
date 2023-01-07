using API_Filmes.Models;
using System.ComponentModel.DataAnnotations;

namespace API_Filmes.Data.DTOs
{
    public class CreateMovieDto
    {
        [Required(ErrorMessage = "Film must have a title")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        [Range(1, 600, ErrorMessage = "Film lenght exceed maximum of 600 minutes")]
        public int Lenght { get; set; }
    }
}
