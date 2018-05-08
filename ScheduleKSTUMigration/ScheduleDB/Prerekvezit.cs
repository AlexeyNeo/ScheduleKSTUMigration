namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prerekvezit")]
    public partial class Prerekvezit
    {
        [Key]
        public int id_prerekvezit { get; set; }

        [StringLength(50)]
        public string code_discipline { get; set; }

        [StringLength(50)]
        public string pre_code_discipline { get; set; }
    }
}
