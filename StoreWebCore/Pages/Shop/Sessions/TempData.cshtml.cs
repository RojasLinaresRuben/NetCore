using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Helpers;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class TempDataModel : PageModel
    {
        [BindProperty]
        public Product product { get; set; }


        public void OnGet()
        {
            product = new Product();
        }

        public IActionResult OnPost(int age, string username, Product product)
        {
            
            TempData["Age"] = age;
            TempData["username"] = username;
            TempDataHelper.Put(TempData, "Product", product);
            return RedirectToPage("ShowFlashAttributes");
        }
    }
}
