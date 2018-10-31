using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoCommerceApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GET()
        {
            return new Product[]
            {
                new Product(1, "Oats", new decimal(3.07)),
                new Product(2, "Toothpaste", new decimal(10.89)),
                new Product(3, "Television", new decimal(500.90)),
            };
        }
        
    }
}
