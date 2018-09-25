namespace Otiport.API.Data.DTOs.Treatment {
    public class TreatmentToPatientDTO : BaseDTO<int> {
        public int TreatmentId { get; set; }
        public int PatientId { get; set; }
    }
}