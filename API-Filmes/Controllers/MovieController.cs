using API_Filmes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Filmes.Controllers
{
    [ApiController]
    [Route("api/movie")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 1;

        [HttpPost("new-movie")]
        public IActionResult AddMovie([FromBody]Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);

            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            if (movies.Count > 0) return Ok(movies);

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = movies.FirstOrDefault(movie => movie.Id == id);

            if (movie == null) return NotFound(new { Message = "Id not found" });

            return Ok(movie);
            
        }
    }
}
