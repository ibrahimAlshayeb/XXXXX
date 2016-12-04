namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.Pregnancy")]
    public partial class Pregnancy
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MotherId { get; set; }

        public DateTime? EstDeliveryDate { get; set; }

        public DateTime? ActDeliveryDate { get; set; }

        [StringLength(50)]
        public string TypeOfDelivery { get; set; }

        [StringLength(50)]
        public string PlaceOfDelivery { get; set; }

        [StringLength(200)]
        public string Complications { get; set; }

        public int? OutcomeOfPregnancy { get; set; }

        [StringLength(200)]
        public string AdditionalRemarks { get; set; }

        public DateTime? LMP { get; set; }

        public DateTime? EDD { get; set; }

        [StringLength(50)]
        public string FPG1 { get; set; }

        [StringLength(50)]
        public string FPG2 { get; set; }

        public DateTime? TTimmunizationLastDoseDate { get; set; }

        public DateTime? TTimmunizationSupportiveDoseDate { get; set; }

        [StringLength(20)]
        public string WeeksOfPregnancy { get; set; }

        [StringLength(50)]
        public string Episiotomy { get; set; }

        [StringLength(50)]
        public string PerinealTear { get; set; }

        public bool? BleedingAfterDelivery { get; set; }

        [StringLength(500)]
        public string BloodTransfusionReason { get; set; }

        [StringLength(20)]
        public string BloodTransfusionDate { get; set; }

        [StringLength(50)]
        public string Hb { get; set; }

        [StringLength(20)]
        public string Temp { get; set; }

        [StringLength(20)]
        public string BP { get; set; }

        [StringLength(50)]
        public string Diagnosis { get; set; }

        public bool? Reffered { get; set; }

        [StringLength(50)]
        public string NameofDoctor { get; set; }

        [StringLength(50)]
        public string BirthAttendant { get; set; }
    }
}
