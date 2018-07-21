using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaviNokta.Entities.Users
{
    [Table("ProfileItemToUser")]
    public class ProfileItemToUserEntity : BaseEntity<Guid>
    {
        public int ProfileItemId { get; set; }
        public int UserId { get; set; }

        //relations
        public virtual ProfileItemEntity ProfileItem { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
