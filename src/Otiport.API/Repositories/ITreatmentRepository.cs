using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.Treatment;

namespace Otiport.API.Repositories
{
    public interface ITreatmentRepository
    {
        Task<IEnumerable<TreatmentEntity>> GetTreatmentsAsync();
        Task<bool> AddTreatmentAsync(TreatmentEntity entity);
        Task<bool> DeleteTreatmentAsync(TreatmentEntity entity);
        Task<TreatmentEntity> GetTreatmentById(int id);
        Task<bool> UpdateTreatmentsAsync(TreatmentEntity entity);
    }
}
