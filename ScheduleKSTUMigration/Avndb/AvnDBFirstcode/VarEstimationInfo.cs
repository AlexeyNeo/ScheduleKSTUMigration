namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VarEstimationInfo")]
    public partial class VarEstimationInfo
    {
        public double? beg_bal { get; set; }

        public double? end_bal { get; set; }

        public int? id_estimation { get; set; }

        public int? id_ebe_var { get; set; }

        [StringLength(50)]
        public string estimation { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_ebe { get; set; }
    }
}
