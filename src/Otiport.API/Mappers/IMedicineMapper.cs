using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Medicine;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Mappers
{
    public interface IMedicineMapper
    {
        MedicineModel ToModel(MedicineEntity entity);
        MedicineEntity ToEntity(MedicineModel model);
    }
}
