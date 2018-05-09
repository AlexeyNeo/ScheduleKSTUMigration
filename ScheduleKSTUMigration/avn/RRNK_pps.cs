namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNK_pps
    {
        [Key]
        public int id_rrnk_pps { get; set; }

        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        public int? id_rrnk_doljnost { get; set; }

        public double? skor_stavka { get; set; }

        public int? id_kassa { get; set; }
    }
}
