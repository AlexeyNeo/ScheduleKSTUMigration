namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Progs
    {
        [Key]
        public int id_avn_progs { get; set; }

        public int? id_avn_security { get; set; }

        public int? id_prog_id { get; set; }
    }
}
