namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class discipline_type
    {
        [Key]
        public int id_discipline_type { get; set; }

        [StringLength(5)]
        public string s_disc_type { get; set; }

        [StringLength(90)]
        public string disc_type { get; set; }
    }
}
