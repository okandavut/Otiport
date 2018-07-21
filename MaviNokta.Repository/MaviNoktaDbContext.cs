using MaviNokta.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;

namespace MaviNokta.Repository
{
    public class MaviNoktaDbContext : DbContext
    {
        public MaviNoktaDbContext(DbContextOptions<MaviNoktaDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<UserGroupEntity> UserGroups { get; set; }
    }
}
