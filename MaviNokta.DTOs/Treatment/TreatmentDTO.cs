using System;
using System.Collections.Generic;
using System.Text;
using MaviNokta.Entities;

namespace MaviNokta.DTOs.Treatment {
    public class TreatmentDTO : BaseEntity<int> {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}