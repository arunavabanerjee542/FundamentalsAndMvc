using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsAndMVC.Models
{
    public static class ExtentionToShoppingCart
    {

        public static int TotalPrice(this ShoppingCart cart)
        {
            int total = 0;
            foreach(var product in cart.Products)
            {
                total += product?.price ?? 0;
            }
            return total;
        }


    }
}
