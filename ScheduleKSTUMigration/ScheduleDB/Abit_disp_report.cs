namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_disp_report
    {
        [Key]
        public int id_disc { get; set; }

        [StringLength(250)]
        public string Discipline { get; set; }
    }
}
