using Microsoft.EntityFrameworkCore;
using Otiport.API.Data.Entities.Patient;
using Otiport.API.Data.Entities.ProfileItem;
using Otiport.API.Data.Entities.Treatment;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Data
{
    public class OtiportDbContext : DbContext
    {
        public OtiportDbContext(DbContextOptions<OtiportDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<UserGroupEntity> UserGroups { get; set; }
        public virtual DbSet<PatientEntity> Patients { get; set; }  
        public virtual DbSet<ProfileItemEntity> ProfileItems { get; set; }  
        public virtual DbSet<ProfileItemToPatientEntity> ProfileItemsToPatients { get; set; }  
        public virtual DbSet<TreatmentEntity> Treatments { get; set; }
        public virtual DbSet<TreatmentToPatientEntity> ThreatmentToPatients { get; set; }
    }
}
