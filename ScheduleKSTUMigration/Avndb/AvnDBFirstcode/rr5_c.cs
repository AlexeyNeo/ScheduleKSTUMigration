namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rr5_c
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(56)]
        public string s_t_fio { get; set; }

        [StringLength(100)]
        public string n_element { get; set; }

        public double? times { get; set; }

        public int? id_rrnk_elements { get; set; }

        [StringLength(50)]
        public string n_type_chasov { get; set; }

        [StringLength(50)]
        public string post { get; set; }

        public int? chasy { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_teacher { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? id_kassa { get; set; }

        public int? id_w_s { get; set; }

        public int? id_f_educ_vid { get; set; }

        [StringLength(50)]
        public string f_educ_vid { get; set; }

        public int? id_faculty { get; set; }

        [Column("p23-1")]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Column("p23-2")]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_umn { get; set; }

        public double? vsego { get; set; }

        public double? stavka { get; set; }

        public double? stavka_b { get; set; }

        public double? stavka_k { get; set; }

        public double? b_times { get; set; }

        public double? k_times { get; set; }

        public double? vak_times { get; set; }

        public double? vak_stavka { get; set; }
    }
}
