using Microsoft.AspNetCore.Mvc;
using WebApplication_Vidly.Models;

namespace WebApplication_Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> Customers { get; set; }
        public CustomersController()
        {
            Customers = new List<Customer> {
                new Customer()
                    {
                        Id = 1,
                        Name = "Customer - 1"
                },new Customer()
                    {
                        Id = 2,
                        Name = "Customer - 2"
                },new Customer()
                    {
                        Id = 3,
                        Name = "Customer - 3"
                },new Customer()
                    {
                        Id = 4,
                        Name = "Customer - 4"
                },new Customer()
                    {
                        Id = 5,
                        Name = "Customer - 5"
                },
            };
        }
        public IActionResult Index()
        {
            return View(Customers);
        }
    }
}
