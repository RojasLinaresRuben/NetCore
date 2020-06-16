using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace StoreWebCore.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required]
        [RegularExpression("[a-z]")]
        public string Password { get; set; }

        [Range(18,20)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }


    }
}
