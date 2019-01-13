using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.ProfileItems
{
    public class DeleteProfileItemRequest : RequestBase
    {
        public int ProfileItemId { get; set; }
    }
}
