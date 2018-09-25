namespace Otiport.API.Data.DTOs.Patient {
    public class PatientDTO : BaseEntity<Guid> {

        public PatientDTO () {
            this.Id = Guid.NewGuid ();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public byte Gender { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ProfilePictureUrl { get; set; }

    }
}