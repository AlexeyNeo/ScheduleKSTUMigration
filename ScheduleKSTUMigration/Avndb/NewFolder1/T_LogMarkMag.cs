namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_LogMarkMag
    {
        [Key]
        public int id_mark_magLog { get; set; }

        public int id_mark_mag { get; set; }

        public DateTime changed { get; set; }

        [Required]
        [StringLength(100)]
        public string host { get; set; }
    }
}
