namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p1
    {
        [Key]
        [Column(Order = 0)]
        public int id_vakansiya { get; set; }

        [Key]
        [Column(Order = 1)]
        public float q_units { get; set; }
    }
}
