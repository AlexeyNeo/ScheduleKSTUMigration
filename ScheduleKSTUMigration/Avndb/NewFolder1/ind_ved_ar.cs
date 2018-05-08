namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ind_ved_ar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

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
        public int id_examination { get; set; }

        public int? id_estimation { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public double? ball { get; set; }

        public DateTime? p36 { get; set; }

        public int? id_f_est { get; set; }

        public int? id_component { get; set; }

        public int? id_kind { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p54 { get; set; }

        public int? sel_leto { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int leave_rate { get; set; }

        [Key]
        [Column(Order = 10)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 11)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 12)]
        public double p53 { get; set; }

        public double? seminar { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_control { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string p22 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [StringLength(10)]
        public string p45 { get; set; }

        [StringLength(10)]
        public string s_component { get; set; }
    }
}
