namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Universities
    {
        [Key]
        public int id_university { get; set; }

        [Required]
        [StringLength(500)]
        public string name { get; set; }
    }
}
