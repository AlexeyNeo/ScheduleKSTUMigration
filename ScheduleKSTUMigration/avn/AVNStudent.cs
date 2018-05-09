namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AVNStudent")]
    public partial class AVNStudent
    {
        [Key]
        public int id_avn_student { get; set; }

        public int? id_avn_login { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }
    }
}
