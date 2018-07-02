using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaviNokta.Entities.Users
{
    [Table("Users")]
    public class UserEntity : BaseEntity<Guid>
    {
        public UserEntity()
        {
            this.Id = Guid.NewGuid();
        }

        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserGroupId { get; set; }

        //relations
        public virtual UserGroupEntity UserGroup { get; set; }
    }
}
