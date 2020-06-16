using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebCore.ViewComponents
{

    [ViewComponent (Name = "Vendor")]
    public class VendorViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync() {
            List<string> vendor = new List<string>() {
                "vendor 1",
                "vendor 2",
                "vendor 3",
                "vendor 4",
                "vendor 5"

            };
            return View("vendor", vendor);
        }
    }
}
