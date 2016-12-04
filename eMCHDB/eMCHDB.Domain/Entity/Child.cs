namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.Child")]
    public partial class Child
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(20)]
        public string MotherId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string CHR { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        public int? PregnancyOutcome { get; set; }

        [StringLength(20)]
        public string GMWeight { get; set; }

        [StringLength(20)]
        public string Length { get; set; }

        [StringLength(20)]
        public string HC { get; set; }

        [StringLength(20)]
        public string Temp { get; set; }

        [StringLength(50)]
        public string PulseAt0 { get; set; }

        [StringLength(50)]
        public string PulseAt12 { get; set; }

        [StringLength(50)]
        public string PulseAt36 { get; set; }

        public bool? RespiratoryRate { get; set; }

        [StringLength(50)]
        public string ApgarScore1 { get; set; }

        [StringLength(50)]
        public string ApgarScore5 { get; set; }

        public string BreastFeedingInFirstHour { get; set; }

        public bool? CongenitalMalformation { get; set; }

        [StringLength(1000)]
        public string TookMedication { get; set; }

        [StringLength(1000)]
        public string Medication { get; set; }

        public bool? VitK { get; set; }

        [StringLength(50)]
        public string HepatitisB { get; set; }

        [StringLength(200)]
        public string Complications { get; set; }

        [StringLength(50)]
        public string Diagnosis { get; set; }

        public bool? Reffered { get; set; }

        [StringLength(20)]
        public string NameOfDoctor { get; set; }
    }
}
