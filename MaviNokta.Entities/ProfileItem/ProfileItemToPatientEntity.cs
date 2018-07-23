using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaviNokta.Entities.Users {
    [Table ("ProfileItemsToPatients")]
    public class ProfileItemToPatientEntity : BaseEntity<int> {

        public int ProfileItemId { get; set; }
        public int PatientId { get; set; }

        //relations
        public virtual ProfileItemEntity ProfileItem { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}