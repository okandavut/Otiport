using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.Treatments
{
    public class AddTreatmentRequest :RequestBase
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
