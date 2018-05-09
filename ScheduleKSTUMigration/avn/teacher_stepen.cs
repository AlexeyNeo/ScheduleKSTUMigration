namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_stepen
    {
        [Key]
        public int id_teacher_stepen { get; set; }

        [Column("teacher_stepen")]
        [StringLength(250)]
        public string teacher_stepen1 { get; set; }
    }
}
