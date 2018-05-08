namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_spec_disp
    {
        [Key]
        public int id_abit_spec_disp { get; set; }

        public int id_speciality { get; set; }

        [StringLength(250)]
        public string discipline { get; set; }
    }
}
