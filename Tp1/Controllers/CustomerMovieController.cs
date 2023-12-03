using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Tp1.Models;

namespace Tp1.Controllers
{
    public class CustomerMovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie{ Name = "Iron Man" },
                new Movie{ Name = "Thor" },
            };

            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Sara"
            };

            CustomerMovieVM viewModel = new CustomerMovieVM(customer, movies); 
            return View(viewModel);
        }
    }
}
