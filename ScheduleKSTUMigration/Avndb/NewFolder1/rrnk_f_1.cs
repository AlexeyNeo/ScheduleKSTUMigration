namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_f_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string educ_form { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_form { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 7)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double p53 { get; set; }

        public double? rzr { get; set; }

        public double? kpr_ind_z_pl { get; set; }

        public double? n_kpr_ind_z_pl { get; set; }

        public double? seminar { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        public int? kol_st_gr_all { get; set; }

        public int? kol_st_gr_all_b { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int not_sel { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kpr { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int n_kpr { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kp { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kr { get; set; }

        public double? kpr_prov_reyt_rrnk { get; set; }

        public double? n_kpr_prov_reyt_rrnk { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 16)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        public double? kpr_ind_z_rrnk { get; set; }

        public double? n_kpr_ind_z_rrnk { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int n_kpr_id_exam { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kpr_id_exam { get; set; }

        public int? n_kpr_id_teacher_sum { get; set; }

        public int? kpr_id_teacher_sum { get; set; }

        public double? n_lk { get; set; }

        public double? n_lb { get; set; }

        public double? n_pr { get; set; }

        public double? n_sem { get; set; }

        public double? prov_reyt { get; set; }

        public double? rukov_uch_pr { get; set; }

        public double? rukov_pr_pr { get; set; }

        public double? rukov_pd_pr { get; set; }

        public double? rukov_d_proj { get; set; }

        public double? gr_kons { get; set; }

        public double? ind_kons { get; set; }

        public double? recenth_reyt { get; set; }

        public double? recenth_kr { get; set; }

        public double? recenth_dp { get; set; }

        public double? irs { get; set; }

        public double? konsul_dl { get; set; }

        public double? uchastie_v_gak { get; set; }

        public double? prochie { get; set; }

        public double? ind_zan { get; set; }

        public double? rec_ruk_kontrrab { get; set; }

        public double? recenth { get; set; }

        public double? rucov { get; set; }
    }
}
