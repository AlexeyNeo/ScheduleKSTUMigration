namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prikaz_come_slushatel
    {
        [Key]
        public int id_prikaz_come_slushatel { get; set; }

        [StringLength(50)]
        public string prikaz_come { get; set; }
    }
}
