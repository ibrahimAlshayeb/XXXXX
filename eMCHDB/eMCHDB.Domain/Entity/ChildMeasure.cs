namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.ChildMeasures")]
    public partial class ChildMeasure
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ChildId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(20)]
        public string Age { get; set; }

        [StringLength(20)]
        public string Weight { get; set; }

        [StringLength(20)]
        public string Height { get; set; }

        [StringLength(20)]
        public string HC { get; set; }

        public string Remarks { get; set; }

        [StringLength(50)]
        public string NurseName { get; set; }
    }
}
