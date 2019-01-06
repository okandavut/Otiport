using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Data.Entities.Medicine
{
    [Table("Medicines")]
    public class MedicineEntity : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
