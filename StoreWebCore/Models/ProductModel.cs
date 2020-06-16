using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebCore.Models
{
    public class ProductModel
    {
        public List<Product> Products;

        public ProductModel() {
            Products = new List<Product>() {
                new Product{
                    Id="po1",
                    Name="name 1",
                    Price=4,
                    Photo="thumb1.gif"
                },
                 new Product{
                    Id="po2",
                    Name="name 2",
                    Price=2,
                    Photo="thumb2.gif"
                },
                  new Product{
                    Id="po3",
                    Name="name 3",
                    Price=8,
                    Photo="thumb3.gif"
                }
            };
        }

        public List<Product> FindAll() {
            return Products;
        }

        public Product Find(string id) {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
