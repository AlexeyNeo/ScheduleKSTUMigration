namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNK_gr_kolst
    {
        [Key]
        public int id_rrnk_gr_kolst { get; set; }

        public int? id_rate { get; set; }

        public int? id_group { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }
    }
}
