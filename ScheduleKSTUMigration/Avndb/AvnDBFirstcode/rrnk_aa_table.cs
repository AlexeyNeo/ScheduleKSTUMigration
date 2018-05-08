namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_aa_table
    {
        public int? id_rrnk { get; set; }

        public int? id_teacher { get; set; }

        public int? id_group { get; set; }

        public int? id_type_chasov { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p51 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p52 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p53 { get; set; }

        public int? seminar { get; set; }

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

        public double? rec_ruk_kontrrab { get; set; }

        public double? recenth { get; set; }

        public double? rucov { get; set; }
    }
}
