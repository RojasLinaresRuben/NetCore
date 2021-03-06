﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebCore.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public List<Language> Languages { get; set; }
        public string Gender { get; set; }
        public string[] Hobbies { get; set; }
        public string Role { get; set; }
    }
}
