namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RRNKDop")]
    public partial class RRNKDop
    {
        [Key]
        public int id_rrnk_dop { get; set; }

        public int? id_teacher { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_a_year { get; set; }

        public double? hour { get; set; }

        [StringLength(100)]
        public string forWhat { get; set; }

        public int? id_type_chasov { get; set; }

        public byte? plan_fakt { get; set; }

        public int? id_kassa { get; set; }

        public int? id_bk { get; set; }

        public int id_ws { get; set; }
    }
}
