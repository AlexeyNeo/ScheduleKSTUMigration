namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("123")]
    public partial class C123
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        [Key]
        [Column(Order = 6)]
        public double n_lk { get; set; }

        [Key]
        [Column(Order = 7)]
        public double n_lb { get; set; }

        [Key]
        [Column(Order = 8)]
        public double n_pr { get; set; }

        [Key]
        [Column(Order = 9)]
        public double n_sem { get; set; }

        [Key]
        [Column(Order = 10)]
        public double manual_kp { get; set; }

        [Key]
        [Column(Order = 11)]
        public double ind_zan { get; set; }

        [Key]
        [Column(Order = 12)]
        public double prov_reyt { get; set; }

        [Key]
        [Column(Order = 13)]
        public double recenth_kr { get; set; }

        public double? rukov_uch_pr { get; set; }

        public double? rukov_pr_pr { get; set; }

        public double? rukov_pd_pr { get; set; }

        public double? konsul_dl { get; set; }

        public double? uchastie_v_gak { get; set; }

        public double? irs { get; set; }

        public double? prochie { get; set; }

        public double? rec_ruk_kontrrab { get; set; }

        public double? recenth { get; set; }

        public double? rucov { get; set; }

        public double? indivKonsult { get; set; }

        public double? groupKonsult { get; set; }

        public double? srsPriemKontrol { get; set; }

        public double? interactive { get; set; }

        public byte? plan_fakt { get; set; }

        public int? id_teacher { get; set; }
    }
}
