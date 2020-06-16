using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Helpers;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop.Sessions
{
    public class Session2Model : PageModel
    {
        public int? age { get; set; }
        public string username { get; set; }

        public Product product { get; set; }

        public List<Product> listProducts { get; set; }
        public void OnGet()
        {
            age = HttpContext.Session.GetInt32("age");
            username = HttpContext.Session.GetString("username");
            product = SessionHelpers.GetOBjectFromJson<Product>(HttpContext.Session, "product");
            listProducts = SessionHelpers.GetOBjectFromJson<List<Product>>(HttpContext.Session, "products");
        }
    }
}
