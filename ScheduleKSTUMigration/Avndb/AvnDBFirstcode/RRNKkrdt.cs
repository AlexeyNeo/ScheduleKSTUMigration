namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RRNKkrdt")]
    public partial class RRNKkrdt
    {
        [Key]
        public int id_rrnkKrdt { get; set; }

        public int? id_disciplineName { get; set; }

        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        public int? id_discipline { get; set; }

        public int? id_semester { get; set; }

        public byte? subgroup { get; set; }

        public double? n_lk { get; set; }

        public double? n_lb { get; set; }

        public double? n_pr { get; set; }

        public double? n_sem { get; set; }

        public double? manual_kp { get; set; }

        public double? gr_kons { get; set; }

        public double? ind_zan { get; set; }

        public double? ind_kons { get; set; }

        public double? prov_reyt { get; set; }

        public double? recenth_reyt { get; set; }

        public double? recenth_kr { get; set; }

        public double? rukov_uch_pr { get; set; }

        public double? rukov_pr_pr { get; set; }

        public double? rukov_pd_pr { get; set; }

        public double? rukov_d_proj { get; set; }

        public double? konsul_dl { get; set; }

        public double? recenth_dp { get; set; }

        public double? uchastie_v_gak { get; set; }

        public double? irs { get; set; }

        public double? prochie { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public double? rec_ruk_kontrrab { get; set; }

        public int? id_type_chasov { get; set; }

        public double? recenth { get; set; }

        public double? rucov { get; set; }

        public int? id_examination { get; set; }

        public int? id_w_s { get; set; }

        public byte? plan_fakt { get; set; }

        public int? id_o_z { get; set; }

        public double? indivKonsult { get; set; }

        public double? groupKonsult { get; set; }

        public double? srsPriemKontrol { get; set; }

        public int? id_ebe_var { get; set; }

        public double? interactive { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? id_f_educ { get; set; }

        public int? kredit { get; set; }

        public bool? tempUpdated { get; set; }

        [Required]
        [StringLength(251)]
        public string dop_potokname { get; set; }

        public double? online { get; set; }

        public double? offline { get; set; }

        public byte? praktika_rasp { get; set; }

        public int beg_nedel { get; set; }

        public int end_nedel { get; set; }
    }
}
