namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DATE_reg_DFS
    {
        [Key]
        public int id_date_DFS { get; set; }

        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_f_educ { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? id_AVN_user { get; set; }

        public DateTime? AVN_log_date { get; set; }

        [StringLength(150)]
        public string host { get; set; }
    }
}
