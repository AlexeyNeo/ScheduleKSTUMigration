namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trudoem")]
    public partial class Trudoem
    {
        [Key]
        public int id_trudoem { get; set; }

        [Column("trudoem")]
        [StringLength(50)]
        public string trudoem1 { get; set; }
    }
}
