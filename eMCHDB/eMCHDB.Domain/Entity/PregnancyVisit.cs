namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.PregnancyVisits")]
    public partial class PregnancyVisit
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        [StringLength(20)]
        public string PregnancyId { get; set; }

        public DateTime? DateOfVisit { get; set; }

        [StringLength(20)]
        public string GestationalAge { get; set; }

        public bool? PregnancyInducedDiabetes { get; set; }

        public bool? HypertesionDiastolic { get; set; }

        public int? oedema { get; set; }

        [StringLength(50)]
        public string Proteinuria { get; set; }

        [StringLength(50)]
        public string AnaemiaHb { get; set; }

        [StringLength(20)]
        public string FundalHeight { get; set; }

        [StringLength(20)]
        public string Malpresentation { get; set; }

        public bool? AbsenceOfFoetal { get; set; }

        [StringLength(50)]
        public string OtherRiskFactors { get; set; }

        [StringLength(50)]
        public string RiskScore { get; set; }

        [StringLength(20)]
        public string Weight { get; set; }

        [StringLength(50)]
        public string UrineAlb { get; set; }

        [StringLength(50)]
        public string UrineSug { get; set; }

        [StringLength(50)]
        public string Hb { get; set; }

        [StringLength(20)]
        public string BP { get; set; }

        [StringLength(20)]
        public string Presentation { get; set; }

        public bool? FoetalHeart { get; set; }
    }
}
