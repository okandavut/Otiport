using System;
using System.Collections.Generic;
using System.Text;

namespace Otiport.DTOs.Users {
    public class ProfileItemToUserDTO : BaseDTO<int> {
        public int ProfileItemId { get; set; }
        public int UserId { get; set; }
 
    }
}