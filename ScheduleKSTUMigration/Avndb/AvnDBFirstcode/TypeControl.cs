namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeControl")]
    public partial class TypeControl
    {
        [Key]
        public int id_typeControl { get; set; }

        [Column("typeControl")]
        [StringLength(20)]
        public string typeControl1 { get; set; }
    }
}
