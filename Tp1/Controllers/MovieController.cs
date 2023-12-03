using Microsoft.AspNetCore.Mvc;
using Tp1.Models;

namespace Tp1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
            };
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        [Route("Movie/released/{month}/{year}")]
        public IActionResult ByRelease(int month, int year)
        {
            return Content($"{month}/{year}");
        }
    }
}
