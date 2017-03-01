using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrids.Models;

namespace WebGrids.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "PC", Price = 1200, Count = 200 },
                new Product { ID = 2, Name = "Laptop", Price = 1300, Count = 300 },
                new Product { ID = 3, Name = "LCD", Price = 1400, Count = 400 },
                new Product { ID = 4, Name = "LED", Price = 1500, Count = 500 },
                new Product { ID = 5, Name = "Smart", Price = 1600, Count = 600 },
                new Product { ID = 6, Name = "Tablet", Price = 1700, Count = 700 }
            };
            return View(products);
        }
    }
}