using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;

namespace Otiport.API.Contract.Response.ProfileItems
{
    public class GetProfileItemsResponse : ResponseBase
    {
        public IEnumerable<ProfileItemModel> ProfileItems { get; set; }
    }
}
