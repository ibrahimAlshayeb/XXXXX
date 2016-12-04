namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.FamilyPlanning")]
    public partial class FamilyPlanning
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        [StringLength(20)]
        public string PregnancyId { get; set; }

        public bool? UseFPNow { get; set; }

        public bool? UseFPBefore { get; set; }

        [StringLength(50)]
        public string FPSelectedWay { get; set; }
    }
}
