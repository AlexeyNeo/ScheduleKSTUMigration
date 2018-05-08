namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_rep_user
    {
        [Key]
        public int id_AVN_rep_user { get; set; }

        public int? id_avn_user { get; set; }

        public int? id_avn_report_role { get; set; }

        public virtual AVN_report_role AVN_report_role { get; set; }
    }
}
