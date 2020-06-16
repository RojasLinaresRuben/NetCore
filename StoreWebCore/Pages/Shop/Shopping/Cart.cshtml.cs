using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreWebCore.Helpers;
using StoreWebCore.Models;

namespace StoreWebCore.Pages.Shop
{
    public class CartModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total {get; set;}
        public void OnGet()
        {
            cart = SessionHelpers.GetOBjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i=> i.Product.Price * i.Quantity);
        }

        public IActionResult OnGetBuyNow(string id) {
            var productModel = new ProductModel();
            cart = SessionHelpers.GetOBjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = productModel.Find(id),
                    Quantity = 1

                });

                SessionHelpers.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = productModel.Find(id),
                        Quantity = 1
                    });
                }
                else {
                    cart[index].Quantity++;
                }
                SessionHelpers.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToPage("Cart");
        }

        public IActionResult OnGetDelete(string id) {

            cart = SessionHelpers.GetOBjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelpers.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }


        public IActionResult OnPostUpdate(int[] quantities) {

            cart = SessionHelpers.GetOBjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i <cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }

            SessionHelpers.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Cart");
        }

        private int Exists(List<Item> cart, string id) {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id) {
                    return i;
                }

            }
            return -1;
        }
    }
}
