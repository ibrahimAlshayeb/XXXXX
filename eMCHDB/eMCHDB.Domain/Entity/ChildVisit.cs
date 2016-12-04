namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.ChildVisit")]
    public partial class ChildVisit
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ChildId { get; set; }

        public int? VisitNo { get; set; }

        public int? AgeinMonths { get; set; }

        public DateTime? DateofVisit { get; set; }

        [StringLength(50)]
        public string GeneralAppearance { get; set; }

        [StringLength(50)]
        public string Fontanell { get; set; }

        [StringLength(50)]
        public string Squint { get; set; }

        [StringLength(50)]
        public string MurmersAt0 { get; set; }

        [StringLength(50)]
        public string MurmersAt12 { get; set; }

        [StringLength(50)]
        public string MurmersAt36 { get; set; }

        [StringLength(50)]
        public string Masses { get; set; }

        [StringLength(50)]
        public string Hepatosplenomegally { get; set; }

        [StringLength(50)]
        public string Hernia { get; set; }

        [StringLength(50)]
        public string TesticularExamination { get; set; }

        [StringLength(50)]
        public string hypospadias { get; set; }

        [StringLength(50)]
        public string Dysplasia { get; set; }

        [StringLength(50)]
        public string LimitedAbduction { get; set; }

        [StringLength(50)]
        public string AbnormalSpine { get; set; }

        public int? NormalWalk { get; set; }

        [StringLength(200)]
        public string Caries { get; set; }

        [StringLength(200)]
        public string Others { get; set; }

        [StringLength(20)]
        public string NameofDoctor { get; set; }

        [StringLength(50)]
        public string AbnormalExternalgenitalia { get; set; }

        [StringLength(50)]
        public string InguinalHernia { get; set; }
    }
}
