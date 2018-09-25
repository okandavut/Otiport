namespace Otiport.API.Data.DTOs.Users
{
    public class UserDTO : BaseDTO<Guid>
    {
        public UserDTO()
        {
            this.Id = Guid.NewGuid();
        }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
