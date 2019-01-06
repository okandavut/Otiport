using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Contract.Models;
using Otiport.API.Data.Entities.Treatment;

namespace Otiport.API.Mappers
{
    public interface ITreatmentMapper
    {
        TreatmentModel ToModel(TreatmentEntity entity);
        TreatmentEntity ToEntity(TreatmentModel model);
    }
}
