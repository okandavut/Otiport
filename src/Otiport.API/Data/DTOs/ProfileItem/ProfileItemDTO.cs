using System;
using System.Collections.Generic;
using System.Text;

namespace Otiport.DTOs.Users {
    public class ProfileItemDTO : BaseDTO<int> {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}