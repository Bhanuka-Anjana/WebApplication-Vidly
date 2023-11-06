using Microsoft.AspNetCore.Mvc;
using WebApplication_Vidly.Models;

namespace WebApplication_Vidly.Controllers
{
	public class MoviesController : Controller
	{
		public List<Movie> Movies { get; set; }
		public MoviesController()
		{
			Movies = new List<Movie> {
				new Movie()
					{
						Id = 1,
						Title = "Test - 1",
						Description = "Test description"
				},
				new Movie()
					{
						Id = 2,
						Title = "Test - 2",
						Description = "Test description"
				},
				new Movie()
					{
						Id = 3,
						Title = "Test - 3",
						Description = "Test description"
				},
				new Movie()
					{
						Id = 4,
						Title = "Test - 4",
						Description = "Test description"
				},
			};
		}
		public IActionResult Index()
		{
			return View(Movies);
		}
	}
}
