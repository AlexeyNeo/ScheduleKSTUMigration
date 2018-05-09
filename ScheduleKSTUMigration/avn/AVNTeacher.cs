namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AVNTeacher")]
    public partial class AVNTeacher
    {
        [Key]
        public int id_avn_teacher { get; set; }

        public int? id_avn_login { get; set; }

        public int? id_teacher { get; set; }
    }
}
