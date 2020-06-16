using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreWebCore.Pages.Shop
{
    public class Redirect3Model : PageModel
    {
        [BindProperty(Name ="id1",SupportsGet =true)]
        public int Id1 { get; set; }

        [BindProperty(Name ="id2",SupportsGet =true)]
        public string Id2 { get; set; }
        public void OnGet()
        {
        }

        public void OnGetDisplay()
        { 
        
        }
    }
}
