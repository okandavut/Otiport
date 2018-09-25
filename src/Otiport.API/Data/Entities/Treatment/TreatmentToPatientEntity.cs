using Otiport.API.Data.Entities.Patient;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otiport.API.Data.Entities.Treatment {
    [Table ("ThreatmentToPatients")]
    public class TreatmentToPatientEntity : BaseEntity<int> {

        public int TreatmentId { get; set; }
        public int PatientId { get; set; }

        //relations
        public virtual TreatmentEntity ProfileItem { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}