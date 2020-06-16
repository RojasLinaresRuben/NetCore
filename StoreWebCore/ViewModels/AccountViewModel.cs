using Microsoft.AspNetCore.Mvc.Rendering;
using StoreWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebCore.ViewModels
{
    public class AccountViewModel
    {
        public Account account { get; set; }
        public SelectList Roles { get; set; }
        public SelectList Hobbies { get; set; }
    }
}
