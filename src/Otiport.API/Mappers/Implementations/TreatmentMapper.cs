using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Treatment;

namespace Otiport.API.Mappers.Implementations
{
    public class TreatmentMapper : ITreatmentMapper
    {
        public TreatmentModel ToModel(TreatmentEntity entity)
        {
            return new TreatmentModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description
            };
        }

        public TreatmentEntity ToEntity(TreatmentModel model)
        {
            return new TreatmentEntity()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description
            };
        }
    }
}
