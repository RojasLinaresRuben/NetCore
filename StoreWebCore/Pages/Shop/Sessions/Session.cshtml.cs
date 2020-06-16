using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Helpers;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class SessionModel : PageModel
    {

        public void OnGet()
        {
            HttpContext.Session.SetInt32("age", 20);
            HttpContext.Session.SetString("username", "abc");

            var product = new Product()
            {
                Id = "po1",
                Name = "name 1",
                Price = 4.5
            };

            SessionHelpers.SetObjectAsJson(HttpContext.Session, "product", product);

            var products = new List<Product>()
            {
                new Product{
                    Id="po1",
                    Name="name 1",
                    Price=4.5
                },
                new Product{
                      Id="po2",
                    Name="name 2",
                    Price=11
                },
                new Product{
                      Id="po3",
                    Name="name 3",
                    Price=7
                }
            };

            SessionHelpers.SetObjectAsJson(HttpContext.Session, "products", products);

        }

       
    }
}
