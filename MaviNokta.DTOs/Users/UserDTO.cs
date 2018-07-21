using System;
using System.Collections.Generic;
using System.Text;

namespace MaviNokta.DTOs.Users
{
    public class UserDTO : BaseDTO<Guid>
    {
        public UserDTO()
        {
            this.Id = Guid.NewGuid();
        }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProfilePictureUrl { get; set; }
    }
}
