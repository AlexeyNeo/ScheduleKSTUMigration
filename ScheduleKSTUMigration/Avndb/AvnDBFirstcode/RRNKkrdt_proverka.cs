namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNKkrdt_proverka
    {
        [Key]
        [Column(Order = 0)]
        public int id_rrnkKrdt { get; set; }

        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_w_s { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 1)]
        public double lk { get; set; }

        [Key]
        [Column(Order = 2)]
        public double lb { get; set; }

        [Key]
        [Column(Order = 3)]
        public double pr { get; set; }

        [Key]
        [Column(Order = 4)]
        public double sem { get; set; }

        [Key]
        [Column(Order = 5)]
        public double manual { get; set; }

        [Key]
        [Column(Order = 6)]
        public double gr_kon { get; set; }

        [Key]
        [Column(Order = 7)]
        public double ind_zan1 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double rukov_uch_pr1 { get; set; }

        [Key]
        [Column(Order = 9)]
        public double rukov_pr_pr1 { get; set; }

        [Key]
        [Column(Order = 10)]
        public double rukov_pd_pr1 { get; set; }

        [Key]
        [Column(Order = 11)]
        public double konsul_dl1 { get; set; }

        [Key]
        [Column(Order = 12)]
        public double uchastie_v_gak1 { get; set; }

        [Key]
        [Column(Order = 13)]
        public double irs1 { get; set; }

        [Key]
        [Column(Order = 14)]
        public double prochie1 { get; set; }

        [Key]
        [Column(Order = 15)]
        public double rec_ruk_kontrrab1 { get; set; }

        [Key]
        [Column(Order = 16)]
        public double recenth1 { get; set; }

        [Key]
        [Column(Order = 17)]
        public double rucov1 { get; set; }

        [Key]
        [Column(Order = 18)]
        public double indivKonsult1 { get; set; }

        [Key]
        [Column(Order = 19)]
        public double groupKonsult1 { get; set; }

        [Key]
        [Column(Order = 20)]
        public double srsPriemKontrol1 { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_type_chasov { get; set; }

        public byte? plan_fakt { get; set; }

        public int? kredit { get; set; }

        public byte? subgroup { get; set; }

        [Key]
        [Column(Order = 21)]
        public double REYTING { get; set; }
    }
}
