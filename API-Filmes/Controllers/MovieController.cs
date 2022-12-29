using API_Filmes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API_Filmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();

        [HttpPost]
        public void NewMovie([FromBody]Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine(movie.Title);
        }
    }
}
