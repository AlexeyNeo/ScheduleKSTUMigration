namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebe")]
    public partial class ebe
    {
        [Key]
        public int id_ebe { get; set; }

        public int? id_ebe_var { get; set; }

        public double? beg_bal { get; set; }

        public double? end_bal { get; set; }

        public int? id_estimation { get; set; }
    }
}
