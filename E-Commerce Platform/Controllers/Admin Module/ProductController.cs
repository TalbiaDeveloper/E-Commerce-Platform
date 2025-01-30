using E_Commerce_Platform.Data;
using E_Commerce_Platform.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Platform.Controllers.Admin_Module
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db1;
        public ProductController(ApplicationDbContext db)
        {
            _db1 = db;
        }

        //Retrive
        public IActionResult Product()
        {
            List<Product> obj1ProductList = _db1.Products.ToList();
            return View(obj1ProductList);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
