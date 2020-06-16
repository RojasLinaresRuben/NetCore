using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreWebCore.Pages.Shop
{
    public class MultipleFileUploadModel : PageModel
    {
        private IWebHostEnvironment iwebHostEnviroment;
        public List<string> FileNames { get; set; }

        public MultipleFileUploadModel(IWebHostEnvironment iwebHostEnviroment) {
            this.iwebHostEnviroment = iwebHostEnviroment;
        }
        public void OnGet()
        {
        }

        //photos es el mismo nombre de el valor de name del tag input
        public void OnPost(IFormFile[] photos)
        {
            if (photos != null && photos.Length > 0)
            {
                FileNames = new List<string>();

                foreach (IFormFile photo in photos)
                {
                    var path = Path.Combine(iwebHostEnviroment.WebRootPath, "Images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    FileNames.Add(photo.FileName);
                }
            }

        }

    }
}
