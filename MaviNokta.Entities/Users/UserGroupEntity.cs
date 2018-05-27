using System;
using System.Collections.Generic;
using System.Text;

namespace MaviNokta.Entities.Users
{
    public class UserGroupEntity : BaseEntity<int>
    {
        public string Name { get; set; }

        //relations
        public virtual List<UserEntity> Users { get; set; }
    }
}
