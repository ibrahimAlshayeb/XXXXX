namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.OralHealth")]
    public partial class OralHealth
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ChildId { get; set; }

        public int? Age { get; set; }

        [StringLength(20)]
        public string RiskScoringAssessment { get; set; }

        [StringLength(10)]
        public string FluorideVarnishApplication { get; set; }

        public DateTime? Date { get; set; }
    }
}
