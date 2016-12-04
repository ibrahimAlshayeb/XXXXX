namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.Mother")]
    public partial class Mother
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string RCN { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        public DateTime? DateOfRegistration { get; set; }

        [StringLength(50)]
        public string NameOfHusband { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string HomeTelephoneNumber { get; set; }

        [StringLength(50)]
        public string MobileTelephoneNumber { get; set; }

        public int? HealthCenterId { get; set; }

        public int? FieldID { get; set; }

        [StringLength(5)]
        public string MotherBloodType { get; set; }

        public int? HusbandBloodType { get; set; }
    }
}
