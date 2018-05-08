namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f10_1
    {
        [Key]
        [Column(Order = 0)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s_fio { get; set; }
    }
}
