namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.NewbornAssessment")]
    public partial class NewbornAssessment
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string ChildID { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        [StringLength(20)]
        public string Weight { get; set; }

        [StringLength(20)]
        public string Length { get; set; }

        [StringLength(20)]
        public string HC { get; set; }

        [StringLength(20)]
        public string Temp { get; set; }

        [StringLength(50)]
        public string Pulse { get; set; }

        [StringLength(50)]
        public string RespiratoryRate { get; set; }

        [StringLength(50)]
        public string MoroReflex { get; set; }

        [StringLength(50)]
        public string GraspReflex { get; set; }

        [StringLength(50)]
        public string SucklingReflex { get; set; }

        public bool? CongenitalMalformation { get; set; }

        [StringLength(50)]
        public string NeonatalJaundice { get; set; }

        [StringLength(50)]
        public string NeonatalCyanosis { get; set; }

        [StringLength(50)]
        public string UnbilicalCord { get; set; }

        [StringLength(50)]
        public string HepatitisB { get; set; }

        [StringLength(200)]
        public string AfterBirthComplications { get; set; }

        [StringLength(50)]
        public string Diagnosis { get; set; }

        public bool? Reffered { get; set; }

        [StringLength(20)]
        public string NameofDoctor { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }
    }
}
