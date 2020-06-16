using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Helpers;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class ShowFlashAttributesModel : PageModel
    {
        public Product product { get; set; }
        public int Age { get; set; }

        public string username { get; set; }
        public void OnGet()
        {
            Age = int.Parse(TempData["age"].ToString());
            username = TempData["username"].ToString();
            product = TempDataHelper.Get<Product>(TempData, "product") as Product;
        }
    }
}
