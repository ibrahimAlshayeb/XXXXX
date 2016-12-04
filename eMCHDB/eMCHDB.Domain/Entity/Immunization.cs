namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.Immunizations")]
    public partial class Immunization
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ChildId { get; set; }

        public int? VaccineId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Dose { get; set; }

        [StringLength(100)]
        public string AdverseEvents { get; set; }
    }
}
