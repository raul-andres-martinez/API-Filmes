using System.ComponentModel.DataAnnotations;

namespace API_Filmes.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Genre must have a name")]
        [StringLength(50, ErrorMessage = "Genre lenght exceed 50 characters")]
        public string Name { get; set; }
    }
}
