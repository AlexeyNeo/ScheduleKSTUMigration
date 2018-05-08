namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Smeta_date
    {
        [Key]
        public int id_smeta_date { get; set; }

        public int? id_a_year { get; set; }

        [Column("Smeta_date")]
        public DateTime? Smeta_date1 { get; set; }

        public int? id_AVN_user { get; set; }

        public DateTime? AVN_log_date { get; set; }

        [StringLength(250)]
        public string host { get; set; }
    }
}
