namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rr4_d
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(56)]
        public string s_t_fio { get; set; }

        [StringLength(13)]
        public string n_element { get; set; }

        public double? times { get; set; }

        public double? id_rrnk_elements { get; set; }

        [StringLength(50)]
        public string n_type_chasov { get; set; }

        [StringLength(50)]
        public string post { get; set; }

        public int? chasy { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_teacher { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? id_kassa { get; set; }

        public int? id_faculty { get; set; }
    }
}
