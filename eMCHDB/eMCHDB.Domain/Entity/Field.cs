namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MCHMobile.Fields")]
    public partial class Field
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldID { get; set; }

        [StringLength(50)]
        public string Field_name { get; set; }
    }
}
