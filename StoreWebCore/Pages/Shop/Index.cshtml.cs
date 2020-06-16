using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class IndexModel : PageModel
    {
        private IConfiguration configuration;
        public int Age { get; set; }
        public string Username { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

        public DateTime Birthday { get; set; }

        public Product product { get; set; }

        public List<Product> ProductList { get; set; }

        public List<string> ConfigList { get; set; }

        public string Msg { get; set; }

        public IndexModel(IConfiguration _configuration) {
            configuration = _configuration;
        }

        [BindProperty (Name ="id3", SupportsGet =true)]
        public string Id3 { get; set; }

        [BindProperty(Name = "id4", SupportsGet = true)]
        public int Id4 { get; set; }

        public string Result { get; set; }

        public void OnGet()
        {
            Example();

        }

        //public void OnGetMenu1()
        //{
        //    Example();
        //    this.Msg = "Menu 1 is selected";
        //}

        //public void OnGetMenu2()
        //{
        //    Example();
        //    this.Msg = "Menu 2 is selected";
        //}

        //public void OnGetMenu3()
        //{
        //    Example();
        //    this.Msg = "Menu 3 is selected";
        //}

        public void OnPostSubmit1()
        {
            Example();
            this.Msg = "Submit 1 is working";
        }

        public void OnPostSubmit2()
        {
            Example();
            this.Msg = "Submit 2 is working";
        }

        public void OnPostSubmit3()
        {
            Example();
            this.Msg = "Submit 3 is working";
        }

        public void Example() {
            this.Age = 20;
            this.Username = "abc";
            this.Price = 4.5;
            this.Status = true;
            this.Birthday = DateTime.Now;

            product = new Product
            {
                Id = "po1",
                Name = "Name 1",
                Photo = "thumb.gif",
                Price = 5.5,
                Quantity = 4
            };

            ProductList = new List<Product>() {

                new Product()
                {
                    Id="po1",
                    Name="Name 1",
                    Photo="thumb.gif",
                    Price=5.5,
                    Quantity=4
                },
                new Product()
                {
                    Id="po2",
                    Name="Name 2",
                    Photo="thumb2.gif",
                    Price=7,
                    Quantity=3
                },
                new Product()
                {
                    Id="po3",
                    Name="Name 3",
                    Photo="thumb3.gif",
                    Price=8,
                    Quantity=6
                }
            };

            ConfigList = new List<string>() {
                configuration["Message"],
                configuration["MyConfigs:Config1"],
                configuration["MyConfigs:Config2"],
                configuration["MyConfigs:Config3"],
                configuration["Logging:LogLevel:Default"]
            };
        }

        public void OnGetMenu1(string id1) {
            Example();
            this.Result = "Id1: " + id1;
        }

        public void OnGetMenu2(string id1,int id2)
        {
            Example();
            this.Result = "Id1: " + id1;
            this.Result += "<br>Id2: " + id2;
        }

        public void OnGetMenu3()
        {
            Example();
            this.Result = "Id3: " + Id3;
            this.Result += "<br>Id4: " + Id4;
        }
    }
}
