using Microsoft.AspNetCore.Mvc;
using WebApplication_Vidly.Models;

namespace WebApplication_Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Title = "Test",
                Description = "Test description"
            };

            return View(movie);
        }
    }
}
