using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class ShoppingCarModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.FindAll();
        }
    }
}
