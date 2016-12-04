namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.FPWays")]
    public partial class FPWay
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        public int? FamilyPlanningId { get; set; }

        [StringLength(50)]
        public string Use { get; set; }

        [StringLength(50)]
        public string DiditWork { get; set; }

        [StringLength(50)]
        public string OtherSpecifiy { get; set; }

        [StringLength(200)]
        public string Complications { get; set; }
    }
}
