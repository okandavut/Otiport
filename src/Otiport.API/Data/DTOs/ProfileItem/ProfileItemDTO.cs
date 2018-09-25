namespace Otiport.API.Data.DTOs.ProfileItem {
    public class ProfileItemDTO : BaseDTO<int> {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}