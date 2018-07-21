using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaviNokta.Entities.Users
{
    [Table("ProfilePictures")]
    public class ProfilePicturesEntity : BaseEntity<int>
    {
        [Key]
        public int ProfilePictureId { get; set; }

        public  string Url { get; set; }
    }   
}
