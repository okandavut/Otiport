using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Otiport.API.Data.Entities.Patient;

namespace Otiport.API.Data.Entities.Medicine
{
    [Table("MedicinesToPatients")]
    public class MedicinesToPatientEntity : BaseEntity<int>
    {
        public int MedicineId { get; set; }
        public int PatientId { get; set; }

        //relations
        public virtual MedicineEntity ProfileItem { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}
