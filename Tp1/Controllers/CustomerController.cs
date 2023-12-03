using Microsoft.AspNetCore.Mvc;
using Tp1.Models;

namespace Tp1.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Sara"},
            new Customer { Id = 2, Name = "Eya"},
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Customer c = customers.Find(x => x.Id == id);
            return View(c);
        }

    }
}
