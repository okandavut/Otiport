using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Otiport.API.Data.Entities.AddressInformations
{
    [Table("Countries")]
    public class CountryEntity : BaseEntity<Guid>
    {

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
