namespace Otiport.API.Data.DTOs.ProfileItem {
    public class ProfileItemToUserDTO : BaseDTO<int> {
        public int ProfileItemId { get; set; }
        public int UserId { get; set; }
 
    }
}