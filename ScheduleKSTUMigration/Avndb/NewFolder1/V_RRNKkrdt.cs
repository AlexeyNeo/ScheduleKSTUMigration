namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_RRNKkrdt
    {
        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_w_s { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string p42 { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(50)]
        public string sn_f1 { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? kredit { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }

        public byte? subgroup { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(251)]
        public string dop_potokname { get; set; }

        public int? id_examination { get; set; }
    }
}
