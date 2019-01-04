using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Contract.Response.Medicines
{
    public class GetMedicinesResponse : ResponseBase
    {
        public IEnumerable<MedicineEntity> ListOfMedicines { get; set; }
    }
}
