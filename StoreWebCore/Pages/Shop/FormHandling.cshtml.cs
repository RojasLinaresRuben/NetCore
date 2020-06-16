using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreWebCore.Models;
using StoreWebCore.ViewModels;

namespace StoreWebCore.Pages.Shop
{
    public class FormHandlingModel : PageModel
    {
        [BindProperty]
        public AccountViewModel accountViewModel { get; set; }

        public List<Language> ListLanguages { get; set; } 
        
        public FormHandlingModel() {
            ListLanguages = new List<Language>() {
                new Language(){ Id="L1",Name="Languaje 1",IsChecked=true},
                new Language(){ Id="L2",Name="Languaje 2",IsChecked=false},
                new Language(){ Id="L3",Name="Languaje 3",IsChecked=true},
                new Language(){ Id="L4",Name="Languaje 4",IsChecked=false},
                new Language(){ Id="L5",Name="Languaje 5",IsChecked=false},
            };
        }

        public void OnGet()
        {
            List<Role> roles = new List<Role>() {
                new Role{ Id="r1",Name="Role 1"},
                new Role{ Id="r2",Name="Role 2"},
                new Role{ Id="r3",Name="Role 3"},
                new Role{ Id="r4",Name="Role 4"}

              };

            var hobbies = new List<Hobby>() {
                new Hobby{ Id="hob1",Name="Hobby 1" },
                new Hobby{ Id="hob2",Name="Hobby 2" },
                new Hobby{ Id="hob3",Name="Hobby 3" },
                new Hobby{ Id="hob4",Name="Hobby 4" }

            };

            accountViewModel = new AccountViewModel()
            {
                Roles = new SelectList(roles, "Id", "Name"),
                Hobbies = new SelectList(hobbies, "Id", "Name"),
                account = new Account()
                {
                    Status = true,
                    Gender = "male",
                    Hobbies = new string[] { "hob1", "hob3" },
                    Languages= new List<Language>() {
                          new Language(){ Id="L1",Name="Languaje 1",IsChecked=true},
                            new Language(){ Id="L2",Name="Languaje 2",IsChecked=false},
                            new Language(){ Id="L3",Name="Languaje 3",IsChecked=true},
                            new Language(){ Id="L4",Name="Languaje 4",IsChecked=false},
                            new Language(){ Id="L5",Name="Languaje 5",IsChecked=false}
                    }
                    
                }
            };
        }

       


        public IActionResult OnPost() {
            var account = accountViewModel.account;
          

            //foreach (var language in account.Languages)
            //{
            //    if (language.IsChecked)
            //    {
            //        account.Languages.Add(language);
            //    }
            //}

            Debug.WriteLine("Account information");
            Debug.WriteLine("Username:"+account.Username);
            Debug.WriteLine("Password"+ account.Password);
            Debug.WriteLine("Description"+account.Description);
            Debug.WriteLine("Gender"+account.Gender);
            Debug.WriteLine("Status"+account.Status);
            Debug.WriteLine("Role"+account.Role);
            Debug.WriteLine("Language List");
            foreach (var language in account.Languages)
            {
                Debug.WriteLine("\t"+ language);
            }
            Debug.WriteLine("Hobby List");
            foreach (var hobby in account.Hobbies)
            {
                Debug.WriteLine("\t" + hobby);
            }

            return RedirectToPage("Success");

        }
       

    }
}
