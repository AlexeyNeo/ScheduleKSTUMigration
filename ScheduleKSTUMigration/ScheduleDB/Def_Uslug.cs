namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Def_Uslug
    {
        [Key]
        public int id_def_uslug { get; set; }

        public int? f1 { get; set; }

        public int? f2 { get; set; }

        public int? f3_1 { get; set; }

        public int? f3_2 { get; set; }

        public int? id_kassa { get; set; }

        public int? id_faculty { get; set; }

        public int? opl_leto { get; set; }
    }
}
