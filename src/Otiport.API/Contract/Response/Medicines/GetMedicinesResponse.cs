using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Contract.Response.Medicines
{
    public class GetMedicinesResponse : ResponseBase
    {
        public IEnumerable<MedicineModel> Medicines { get; set; }
    }
}
