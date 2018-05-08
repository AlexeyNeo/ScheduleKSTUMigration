namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class est_config
    {
        [Key]
        public int id_est_config { get; set; }

        public int? id_ebe_var { get; set; }

        public int? order_pole { get; set; }

        [StringLength(50)]
        public string name_pole { get; set; }

        public int? info_or_value { get; set; }

        [StringLength(50)]
        public string pole_mark_mag { get; set; }

        [StringLength(100)]
        public string formula { get; set; }

        public int? min { get; set; }

        public int? max { get; set; }

        public int? id_f_est { get; set; }
    }
}
