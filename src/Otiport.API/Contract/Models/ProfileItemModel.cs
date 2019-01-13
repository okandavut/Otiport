using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Models
{
    public class ProfileItemModel
    {
        public int ProfileItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
