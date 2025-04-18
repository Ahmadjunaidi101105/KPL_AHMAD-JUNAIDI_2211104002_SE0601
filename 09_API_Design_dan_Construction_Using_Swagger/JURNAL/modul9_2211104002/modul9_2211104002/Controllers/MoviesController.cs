using Microsoft.AspNetCore.Mvc;
using modul9_2211104002;
using modul9_NIM.Models;
using System.Collections.Generic;

namespace modul9_NIM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham..."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound("Movie not found");

            return Ok(Movies[id]);
        }

        [HttpPost]
        public ActionResult Add(Movie movie)
        {
            Movies.Add(movie);
            return Ok(new { message = "Movie added successfully" });
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound("Movie not found");

            Movies.RemoveAt(id);
            return Ok(new { message = "Movie deleted successfully" });
        }
    }
}
