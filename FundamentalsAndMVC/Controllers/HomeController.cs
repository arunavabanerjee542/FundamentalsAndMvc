using FundamentalsAndMVC.Models;
using FundamentalsAndMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsAndMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            Product product = new Product();
            List<String> productList = new List<String>();
            foreach(Product item in product.GetAllProducts() )
            {
                string name = item?.Name ?? "NONE";
                int? price = item?.price ?? 0;
                string relate=  item?.Related?.Name ?? "NONE";
                productList.Add(string.Format("Name ={0} Price ={1} Related={2}",name,price,relate));
            }

           ShoppingCart cart = new ShoppingCart() { Products = product.GetAllProducts().ToList() };

            int totalprice= cart.TotalPrice();

            ShoppingViewModel shoppingViewModel = new ShoppingViewModel() { Product = productList, price = totalprice };

            return View(shoppingViewModel);
        }






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
