namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_fakt
    {
        [Key]
        public int id_rrnk_fakt { get; set; }

        public int? vid_rrnk { get; set; }

        public int? id_rrnk { get; set; }

        public int? potok_lk { get; set; }

        public int? potok_lb { get; set; }

        public int? potok_pr { get; set; }

        public int? potok_sem { get; set; }

        public double? chasy_fakt { get; set; }

        public DateTime? AVNDATE { get; set; }
    }
}
