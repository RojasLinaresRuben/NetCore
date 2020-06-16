using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreWebCore.Pages.Shop
{
    public class Redirect0Model : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostRedirect1() {
            return RedirectToPage("Redirect");
        }

        public IActionResult OnPostRedirect2()
        {
            return RedirectToPage("Redirect2","Welcome");
        }

        public IActionResult OnPostRedirect3()
        { 
            return RedirectToPage("Redirect3","Display", new {id1=123,id2="p01" });
        }
    }
}
