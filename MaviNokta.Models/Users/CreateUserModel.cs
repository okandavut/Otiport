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

        [MaxLength(25)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }

        [MaxLength(15)]
        [MinLength(2)]
        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string ProfilePictureUrl { get; set; }

    }
}
