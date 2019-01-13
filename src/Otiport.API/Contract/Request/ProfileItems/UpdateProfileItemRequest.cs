﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Otiport.API.Contract.Request.ProfileItems
{
    public class UpdateProfileItemRequest : RequestBase
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
