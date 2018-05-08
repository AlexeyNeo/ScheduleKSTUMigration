namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_struktura
    {
        [Key]
        public int id_teacher_struktura { get; set; }

        [Column("teacher_struktura")]
        [StringLength(255)]
        public string teacher_struktura1 { get; set; }

        [StringLength(50)]
        public string s_teacher_struktura { get; set; }
    }
}
