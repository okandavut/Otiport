using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Otiport.API.Contract.Models;
using Otiport.API.Data;
using Otiport.API.Data.Entities.Medicine;

namespace Otiport.API.Repositories.Implementations
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly OtiportDbContext _dbContext;
        private readonly ILogger<IMedicineRepository> _logger;

        public MedicineRepository(OtiportDbContext dbContext, ILogger<IMedicineRepository> logger)
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

        public async Task<IEnumerable<MedicineEntity>> GetMedicinesAsync()
        {
            return await _dbContext.Medicines.ToListAsync();
 
        }

        public async Task<bool> AddMedicineAsync(MedicineEntity entity)
        {
            await _dbContext.Medicines.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteMedicineAsync(MedicineEntity entity)
        {
            _dbContext.Medicines.Remove(entity);
            return await SaveAsync();
        }
    }
}
