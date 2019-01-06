using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.Medicines
{
    public class AddMedicineRequest : RequestBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
