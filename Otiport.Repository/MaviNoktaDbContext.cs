using Otiport.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;

namespace Otiport.Repository
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
