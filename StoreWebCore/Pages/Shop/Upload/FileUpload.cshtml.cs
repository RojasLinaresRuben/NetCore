using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreWebCore.Pages.Shop
{
    public class FileUploadModel : PageModel
    {
        private IWebHostEnvironment  iwebHostEnviroment;

        public string FileName { get; set; }

        public FileUploadModel(IWebHostEnvironment iwebHostEnviroment) {
            this.iwebHostEnviroment = iwebHostEnviroment;
        }
        public void OnGet()
        {

        }

        public void OnPost(IFormFile photo)
        {
            var path = Path.Combine(iwebHostEnviroment.WebRootPath, "images", photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream);
            FileName = photo.FileName;
        }
    }
}
