namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNK_krdt_kolst
    {
        [Key]
        public int id_rrnk_krdt_kolst { get; set; }

        public int? id_rrnkkrdt { get; set; }

        public int id_faculty { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        public int? id_discipline { get; set; }

        public int? subgroup { get; set; }

        public int? id_examination { get; set; }

        public int? id_w_s { get; set; }

        public int? id_vid_zaniatiy { get; set; }
    }
}
