using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Otiport.API.Data;
using Otiport.API.Data.Entities.Treatment;

namespace Otiport.API.Repositories.Implementations
{
    public class TreatmentRepository : ITreatmentRepository
    {

        private readonly OtiportDbContext _dbContext;
        private readonly ILogger<ITreatmentRepository> _logger;

        public TreatmentRepository(OtiportDbContext dbContext, ILogger<ITreatmentRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Something went wrong");
                return false;
            }
        }

        public async Task<IEnumerable<TreatmentEntity>> GetTreatmentsAsync()
        {
            return await _dbContext.Treatments.ToListAsync();
        }

        public async Task<bool> AddTreatmentAsync(TreatmentEntity entity)
        {
            await _dbContext.Treatments.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteTreatmentAsync(TreatmentEntity entity)
        {
            _dbContext.Treatments.Remove(entity);
            return await SaveAsync();
        }

        public async Task<TreatmentEntity> GetTreatmentById(int id)
        {
            var treatmentEntity = await _dbContext.Treatments.FindAsync(id);
            return treatmentEntity;
        }

        public async Task<bool> UpdateTreatmentsAsync(TreatmentEntity entity)
        {
            _dbContext.Treatments.Update(entity);
            return await SaveAsync();
        }
    }
}
