using Microsoft.EntityFrameworkCore;
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

    }
}
