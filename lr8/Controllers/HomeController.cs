using lr8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lr8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<Product> products = new List<Product>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(products.Count);
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {
            products.Add(product);
            return View(products.Count);
        }
        [HttpPost]
        public IActionResult ViewProductsAsList()
        {
            return View("ProductAsList", products);
        }
        [HttpPost]
        public IActionResult ViewProductsAsTable()
        {
            return View("ProductAsTable", products);
        }
        [HttpGet]
        public IActionResult ProductsTable()
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Products(List<Product> products)
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
