using Otiport.API.Data.Entities.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Otiport.API.Data.Entities.AddressInformations;

namespace Otiport.API.Data.Entities.Users
{
    [Table("Users")]
    public class UserEntity : BaseEntity<Guid>
    {
        public UserEntity()
        {
            Id = Guid.NewGuid();
        }

        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePictureUrl { get; set; }
        public int UserGroupId { get; set; }

        //relations
        public virtual UserGroupEntity UserGroup { get; set; }
        public virtual List<PatientEntity> Patients { get; set; }
        public virtual CountryEntity Country { get; set; }
        public virtual CityEntity City { get; set; }
        public virtual DistrictEntity District { get; set; }
    }
}
