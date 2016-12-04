namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.ANLabTests")]
    public partial class ANLabTest
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string MotherID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Alb { get; set; }

        [StringLength(50)]
        public string Sug { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [StringLength(50)]
        public string Hb { get; set; }

        [StringLength(50)]
        public string FPG1st { get; set; }

        [StringLength(50)]
        public string FPG2nd { get; set; }

        [StringLength(50)]
        public string OGTT1 { get; set; }

        [StringLength(50)]
        public string OGTT2 { get; set; }

        [StringLength(50)]
        public string FBS { get; set; }

        [StringLength(50)]
        public string PPG { get; set; }
    }
}
