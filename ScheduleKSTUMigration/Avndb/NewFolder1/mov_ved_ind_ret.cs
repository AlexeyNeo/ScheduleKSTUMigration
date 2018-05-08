namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_ved_ind_ret
    {
        [Key]
        public int id_mov_ved_ind_ret { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        [StringLength(250)]
        public string Shifr { get; set; }

        public int? kol { get; set; }

        [StringLength(25)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
