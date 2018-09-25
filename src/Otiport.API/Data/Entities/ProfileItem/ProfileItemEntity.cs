using System.ComponentModel.DataAnnotations.Schema;

namespace Otiport.API.Data.Entities.ProfileItem
{
    [Table("ProfileItems")]
    public class ProfileItemEntity : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
