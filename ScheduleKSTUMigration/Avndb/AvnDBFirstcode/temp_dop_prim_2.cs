namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_dop_prim_2
    {
        [StringLength(50)]
        public string primech { get; set; }

        [Key]
        [StringLength(1)]
        public string prim { get; set; }
    }
}
