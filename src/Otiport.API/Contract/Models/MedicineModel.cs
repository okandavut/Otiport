using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Contract.Models
{
    public class MedicineModel
    {

        public int MedicineId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
