using System;
using Microsoft.EntityFrameworkCore;
using Otiport.API.Data.Entities.Users;

namespace Otiport.API.Repositories
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
