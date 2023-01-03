using API_Filmes.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Filmes.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
