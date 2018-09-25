namespace Otiport.API.Data.DTOs.Treatment {
    public class TreatmentDTO : BaseEntity<int> {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}