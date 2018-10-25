using System;
using System.ComponentModel.DataAnnotations;

namespace Otiport.API.Contract.Models
{
    public class UserModel
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
        public string FirstName { get; set; }

        [MaxLength(25)]
        [MinLength(3)]
        public string MiddleName { get; set; }
        
        [MaxLength(15)]
        [MinLength(2)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public int  CountryId { get; set; }

        public int  CityId { get; set; }

        public  int DistrictId { get; set; }

        public string ProfilePictureUrl { get; set; }

    }
}