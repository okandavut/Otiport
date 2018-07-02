using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace MaviNokta.Models.Users
{
    public class CreateUserModel
    {
        [MaxLength(15)]
        [MinLength(5)]
        [Required]
        public string Username { get; set; }

        [MaxLength(32)]
        [MinLength(8)]
        [Required]
        public string Password { get; set; }
        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
