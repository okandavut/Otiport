using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.Treatments
{
    public class DeleteTreatmentRequest : RequestBase
    {
        public int Id { get; set; }
    }
}
