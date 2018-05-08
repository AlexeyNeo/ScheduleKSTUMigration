namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f28_years
    {
        public int? id_a_year { get; set; }

        [Key]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_login { get; set; }
    }
}
