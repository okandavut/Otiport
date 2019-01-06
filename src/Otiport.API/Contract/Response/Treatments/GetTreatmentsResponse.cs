using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;

namespace Otiport.API.Contract.Response.Treatments
{
    public class GetTreatmentsResponse : ResponseBase
    {
        public IEnumerable<TreatmentModel> Treatments { get; set; }
    }
}
