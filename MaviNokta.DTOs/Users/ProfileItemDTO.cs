using System;
using System.Collections.Generic;
using System.Text;

namespace MaviNokta.DTOs.Users
{
    public class ProfileItemDTO : BaseDTO<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
