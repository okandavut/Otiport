using Otiport.API.Data.Entities.Patient;

namespace Otiport.API.Data.Entities.ProfileItem {
    [Table ("ProfileItemsToPatients")]
    public class ProfileItemToPatientEntity : BaseEntity<int> {

        public int ProfileItemId { get; set; }
        public int PatientId { get; set; }

        //relations
        public virtual ProfileItemEntity ProfileItem { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}