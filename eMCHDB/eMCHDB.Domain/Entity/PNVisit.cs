namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.PNVisits")]
    public partial class PNVisit
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        [StringLength(20)]
        public string PregnancyId { get; set; }

        public DateTime? DateOfVisit { get; set; }

        [StringLength(50)]
        public string Seizures { get; set; }

        [StringLength(50)]
        public string BreastsExamination { get; set; }

        [StringLength(50)]
        public string FundalHeight { get; set; }

        [StringLength(50)]
        public string Lochia { get; set; }

        [StringLength(50)]
        public string EpisiotomyTear { get; set; }

        [StringLength(50)]
        public string Hb { get; set; }

        [StringLength(50)]
        public string FBS { get; set; }

        [StringLength(20)]
        public string BP { get; set; }

        [StringLength(50)]
        public string MaternalFoetalComplications { get; set; }

        [StringLength(50)]
        public string FPCounseling { get; set; }

        public DateTime? FPAppointment { get; set; }
    }
}
