namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_dolg_LOG
    {
        [Key]
        public int id_Library_dolg_LOG { get; set; }

        public int? id_st_tech { get; set; }

        public int? s_t { get; set; }

        [StringLength(50)]
        public string AVN_user_login { get; set; }

        public DateTime? log_date { get; set; }

        public bool? dolg { get; set; }

        [StringLength(100)]
        public string host { get; set; }
    }
}
