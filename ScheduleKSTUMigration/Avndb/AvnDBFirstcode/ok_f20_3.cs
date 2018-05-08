namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ok_f20_3
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string structure { get; set; }

        public double? units { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string name { get; set; }
    }
}
