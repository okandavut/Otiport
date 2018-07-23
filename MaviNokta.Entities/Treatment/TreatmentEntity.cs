using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaviNokta.Entities.Users {
    [Table ("Treatments")]
    public class TreatmentEntity : BaseEntity<int> {

        public string Title { get; set; }
        public string Description { get; set; }
    }
}