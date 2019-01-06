    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Request.Medicines
{
    public class DeleteMedicineRequest : RequestBase
    {
        public int MedicineId { get; set; }
    }
}
