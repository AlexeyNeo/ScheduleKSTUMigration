namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mov_ved_ret
    {
        [Key]
        public int id_reg_vedomost { get; set; }

        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_discipline { get; set; }

        public int? id_teacher { get; set; }

        public int? kredit { get; set; }

        public int? subgroup { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_f_est { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? id_group { get; set; }

        public int? id_semester { get; set; }

        public int? id_examination { get; set; }

        [StringLength(250)]
        public string Shifr { get; set; }

        public int? kol { get; set; }
    }
}
