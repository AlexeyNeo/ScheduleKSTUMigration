namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prikaz_leave_slushatel
    {
        [Key]
        public int id_prikaz_leave_slushatel { get; set; }

        [StringLength(50)]
        public string prikaz_leave { get; set; }
    }
}
