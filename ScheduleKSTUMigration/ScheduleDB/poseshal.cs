namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("poseshal")]
    public partial class poseshal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_poseshal { get; set; }

        [Column("poseshal")]
        [StringLength(50)]
        public string poseshal1 { get; set; }

        [StringLength(50)]
        public string s_poseshal { get; set; }
    }
}
