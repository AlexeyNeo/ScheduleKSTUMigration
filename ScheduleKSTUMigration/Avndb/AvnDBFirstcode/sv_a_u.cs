namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sv_a_u
    {
        public int? id_a_year { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? id_estimation { get; set; }

        public int? id_kafedra { get; set; }

        public double? ball { get; set; }

        public DateTime? p36 { get; set; }

        public int? id_f_est { get; set; }

        public int? id_component { get; set; }

        public int? id_kind { get; set; }

        public int? id_speciality { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p54 { get; set; }

        public int? descGroupNum { get; set; }

        public int? sel_leto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int leave_rate { get; set; }

        [Key]
        [Column(Order = 2)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 4)]
        public double p53 { get; set; }

        public double? seminar { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_control { get; set; }

        public double? m1 { get; set; }

        public double? m2 { get; set; }

        public double? m3 { get; set; }

        public double? m4 { get; set; }

        public int? isSelect { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sort1 { get; set; }

        public int? dg_num { get; set; }

        public int? id_teacher { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_sh { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bk { get; set; }

        public int? Krdt { get; set; }

        public int? kredits { get; set; }

        public int? id_ebe_var { get; set; }

        public double? ekv_num { get; set; }

        [StringLength(5)]
        public string ekv_bukv { get; set; }
    }
}
