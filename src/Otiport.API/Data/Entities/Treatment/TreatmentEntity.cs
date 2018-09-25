using System.ComponentModel.DataAnnotations.Schema;

namespace Otiport.API.Data.Entities.Treatment {
    [Table ("Treatments")]
    public class TreatmentEntity : BaseEntity<int> {

        public string Title { get; set; }
        public string Description { get; set; }
    }
}