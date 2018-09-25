using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otiport.API.Data.Entities.Users
{
    [Table("UserGroups")]
    public class UserGroupEntity : BaseEntity<int>
    {
        public string Name { get; set; }

        //relations
        public virtual List<UserEntity> Users { get; set; }
    }
}
