using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsAndMVC.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int? price { get; set; }
        public Product Related { get; set; }


        public IEnumerable<Product> GetAllProducts()
        {
            Product p1 = new Product() { Name = "Dumbell", price = 699 };
            Product p2 = new Product() { Name = "Bar", price = 299, Related = p1 };
            Product p3 = new Product();

            return new Product[] { p1, p2, p3 };

        }



    }
}
