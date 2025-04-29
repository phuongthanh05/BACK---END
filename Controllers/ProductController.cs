using BTVN.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTVN.Controllers
{
    public class ProductController : Controller
    {
        static List<ModelProduct> products = new List<ModelProduct>
            {
               new ModelProduct { Id = 1, Name = "Laptop Lenovo ThinkPad X1", Price = 2999.99m },
               new ModelProduct { Id = 2, Name = "Laptop dell", Price = 299m },
               new ModelProduct { Id = 3, Name = "Laptop macbook", Price = 3000.99m }
            };
        public IActionResult Detail()
        {
            return View(products);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
