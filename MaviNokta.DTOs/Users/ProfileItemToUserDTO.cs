using System;
using System.Collections.Generic;
using System.Text;

namespace MaviNokta.DTOs.Users
{
    public class ProfileItemToUserDTO : BaseDTO<Guid>
    {
        public int ProfileItemId { get; set; }
        public int UserId { get; set; }
    }
}
