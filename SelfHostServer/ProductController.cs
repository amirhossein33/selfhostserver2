using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer
{
   public class ProductController
    {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "T-Shirt", IsAvailable = true },
            new Product { Id = 2, Name = "Shoes", IsAvailable = false }


        };
        [HttpGet]
        [Route("api/products")]
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
