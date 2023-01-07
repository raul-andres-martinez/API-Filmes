using API_Filmes.Data;
using API_Filmes.Data.DTOs;
using API_Filmes.Models;
using AutoMapper;
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
        private MovieContext _context;
        private IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("new-movie")]
        public IActionResult AddMovie([FromBody]CreateMovieDto movieDto)
        {
            Movie movie = _mapper.Map<Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var list = _context.Movies.ToList();

            if(list.Count > 0)
            {
                return Ok(list);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

            if (movie == null) return NotFound(new { Message = "Id not found" });

            return Ok(movie);
            
        }

        [HttpPut("update-movie/{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] Movie movieUpdate)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

            if (movie != null)
            {        
                movie.Title= movieUpdate.Title;
                movie.Director= movieUpdate.Director;
                movie.Genre = movieUpdate.Genre;
                movie.Lenght = movieUpdate.Lenght;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound(new { Message = "Id not found" });       
        }

        [HttpDelete("delete-movie/{id}")]
        public IActionResult DeleteMovie(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound(new { Message = "Id not found "});
        }
    }
}
