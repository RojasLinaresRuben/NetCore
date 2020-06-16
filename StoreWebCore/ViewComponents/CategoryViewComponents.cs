using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebCore.ViewComponents
{
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() {
            List<string> categories = new List<string>() {
                "category 1",
                 "category 2",
                  "category 3",
                   "category 4",
                    "category 5",
            };
            return View("Category", categories);
        }

    }

}
