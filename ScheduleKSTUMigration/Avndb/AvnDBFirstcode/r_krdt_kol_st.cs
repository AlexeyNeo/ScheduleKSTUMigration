namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class r_krdt_kol_st
    {
        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? kredit { get; set; }

        public int? id_teacher { get; set; }

        public byte? subgroup { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int o_z { get; set; }
    }
}
