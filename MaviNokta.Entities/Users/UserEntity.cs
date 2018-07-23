using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ProfilePictureUrl { get; set; }
        public int UserGroupId { get; set; }  

        //relations
        public virtual UserGroupEntity UserGroup { get; set; }
        public virtual List<PatientEntity> Patients { get; set; }
    }
}
