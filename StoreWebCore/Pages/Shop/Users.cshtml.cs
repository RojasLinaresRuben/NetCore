using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class UsersModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }
        public void OnGet()
        {
            usuario = new Usuario();
        }

        public IActionResult OnPost(Usuario usuario) {
            if (usuario.Username != null && usuario.Username.Equals("abc")) {
                ModelState.AddModelError("account.Username", "Username already exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            else
            {
                return RedirectToPage("Success");
            }
        }
    }
}
