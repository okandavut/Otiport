using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaviNokta.Entities.Users {
    [Table ("ThreatmentToPatients")]
    public class TreatmentToPatientEntity : BaseEntity<int> {

        public int TreatmentId { get; set; }
        public int PatientId { get; set; }

        //relations
        public virtual TreatmentEntity ProfileItem { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}