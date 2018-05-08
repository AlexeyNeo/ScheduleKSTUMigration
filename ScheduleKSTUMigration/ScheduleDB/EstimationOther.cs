namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstimationOther")]
    public partial class EstimationOther
    {
        [Key]
        public int id_estimation_other { get; set; }

        public int? id_ebe_var { get; set; }

        [StringLength(10)]
        public string estimation_other { get; set; }
    }
}
