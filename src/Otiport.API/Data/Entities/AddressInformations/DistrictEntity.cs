using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Data.Entities.AddressInformations
{
    [Table("Districts")]
    public class DistrictEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int CityId { get; set; }

        public virtual CityEntity CityItem { get; set; }
    }
}
