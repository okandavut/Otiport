using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Repositories
{
    public interface IMedicineRepository
    {
        Task<IEnumerable<MedicineEntity>> GetMedicinesAsync();
        Task<bool> AddMedicineAsync(string title, string description);
        Task<bool> DeleteMedicineAsync(int medicineId);
    }
}
