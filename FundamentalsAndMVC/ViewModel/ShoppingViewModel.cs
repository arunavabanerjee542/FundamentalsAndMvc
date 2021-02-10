using FundamentalsAndMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsAndMVC.ViewModel
{
    public class ShoppingViewModel
    {
        public IEnumerable<string> Product { get; set; }
        public int price { get; set; }

    }
}
