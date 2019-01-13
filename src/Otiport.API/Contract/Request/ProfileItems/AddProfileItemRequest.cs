using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.ProfileItems
{
    public class AddProfileItemRequest :RequestBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
