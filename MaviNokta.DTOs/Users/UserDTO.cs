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

        public string Username { get; set; }
    }
}
