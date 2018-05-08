namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Progs_Permiss
    {
        [Key]
        public int id_progs_permiss { get; set; }

        public int? id_AVN_User { get; set; }

        public int? id_prog_list { get; set; }
    }
}
