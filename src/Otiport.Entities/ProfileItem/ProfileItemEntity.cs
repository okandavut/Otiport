using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Otiport.Entities.Users
{
    [Table("ProfileItems")]
    public class ProfileItemEntity : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
