namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ok_f20_2
    {
        [Key]
        [StringLength(10)]
        public string structure { get; set; }

        public double? units { get; set; }
    }
}