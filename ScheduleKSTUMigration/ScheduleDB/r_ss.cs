namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class r_ss
    {
        [Key]
        public int id_r_ss { get; set; }

        public int? rate_movement { get; set; }

        public int? sem_movement { get; set; }

        public int? rate_educ_sh { get; set; }

        public int? sem_educ_sh { get; set; }

        public int? sem_mov_leto { get; set; }
    }
}
