namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ebe_detal
    {
        [Key]
        public int id_ebe_detal { get; set; }

        public int? id_ebe { get; set; }

        public double? beg_bal { get; set; }

        public double? end_bal { get; set; }

        public double? ekv_num { get; set; }

        [StringLength(5)]
        public string ekv_bukv { get; set; }
    }
}
