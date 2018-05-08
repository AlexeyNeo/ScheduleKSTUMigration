namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class group_slushatel
    {
        [Key]
        public int id_group_slushatel { get; set; }

        [StringLength(20)]
        public string name_short { get; set; }

        [StringLength(50)]
        public string name_full { get; set; }

        public int? id_faculty { get; set; }

        public DateTime? srok_obuchenia { get; set; }

        public double? oplata { get; set; }
    }
}
