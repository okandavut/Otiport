using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Contract.Response.Medicines;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Repositories
{
    public interface IMedicineRepository
    {
        Task<IEnumerable<MedicineEntity>> GetMedicinesAsync();
        Task<bool> AddMedicineAsync(MedicineEntity entity);
        Task<bool> DeleteMedicineAsync(MedicineEntity entity);
        Task<MedicineEntity> GetMedicineById(int id);
        Task<bool> UpdateMedicinesAsync(MedicineEntity entity);
    }
}
