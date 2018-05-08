namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RRNKCalc")]
    public partial class RRNKCalc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rrnkCalc { get; set; }

        [StringLength(50)]
        public string formula { get; set; }

        public string descr { get; set; }
    }
}
