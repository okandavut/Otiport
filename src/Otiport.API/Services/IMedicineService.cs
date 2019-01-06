using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Request.Medicines;
using Otiport.API.Contract.Response.Medicines;

namespace Otiport.API.Services
{
    public interface IMedicineService
    {
        Task<AddMedicineResponse> AddMedicineAsync(AddMedicineRequest request);
        Task<DeleteMedicineResponse> DeleteMedicineAsync(DeleteMedicineRequest request);
        Task<GetMedicinesResponse> GetMedicinesAsync(GetMedicinesRequest request);
        Task<UpdateMedicineResponse> UpdateMedicinesAsync(UpdateMedicineRequest request);
    }
}
