﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Contract.Request.Common
{
    public class GetCitiesRequest : RequestBase
    {
        public string CountryId { get; set; }
    }
}
