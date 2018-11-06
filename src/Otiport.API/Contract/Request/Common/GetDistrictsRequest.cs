using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.Common
{
    public class GetDistrictsRequest : RequestBase
    {
        public string CityId { get; set; }
    }
}
