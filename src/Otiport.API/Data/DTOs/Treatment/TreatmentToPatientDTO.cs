using System;
using System.Collections.Generic;
using System.Text;

namespace Otiport.DTOs.Treatment {
    public class TreatmentToPatientDTO : BaseDTO<int> {
        public int TreatmentId { get; set; }
        public int PatientId { get; set; }
    }
}