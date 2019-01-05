using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Mappers.Implementations
{
    public class MedicineMapper : IMedicineMapper
    {
        public MedicineModel ToModel(MedicineEntity entity)
        {
            return new MedicineModel()
            {
                MedicineId = entity.Id,
                Title = entity.Title,
                Description = entity.Description
            };
        }

        public MedicineEntity ToEntity(MedicineModel model)
        {

            return new MedicineEntity()
            {
                Id = model.MedicineId,
                Title = model.Title,
                Description = model.Description
            };
        }
    }
}
