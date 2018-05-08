namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ch1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string p2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string p3 { get; set; }

        public int? Expr1 { get; set; }
    }
}
