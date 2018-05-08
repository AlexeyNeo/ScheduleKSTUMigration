namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Progs_Info
    {
        [Key]
        public int id_prog_list { get; set; }

        [StringLength(151)]
        public string prog_info { get; set; }

        public int? version { get; set; }
    }
}
