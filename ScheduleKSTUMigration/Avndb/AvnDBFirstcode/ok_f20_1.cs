namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ok_f20_1
    {
        [Key]
        [StringLength(10)]
        public string structure { get; set; }

        public double? units { get; set; }
    }
}
