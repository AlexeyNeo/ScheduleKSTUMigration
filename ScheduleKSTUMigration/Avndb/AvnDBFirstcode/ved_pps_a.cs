namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ved_pps_a
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_examination { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [StringLength(10)]
        public string ved1 { get; set; }

        [StringLength(10)]
        public string ved2 { get; set; }

        [StringLength(10)]
        public string ved3 { get; set; }

        public double? m1 { get; set; }

        public double? m2 { get; set; }

        public double? m3 { get; set; }

        public double? m4 { get; set; }

        public double? dop { get; set; }

        public double? dop2 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double ball { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_est { get; set; }

        [StringLength(23)]
        public string ekv_num { get; set; }

        [StringLength(10)]
        public string ekv_bukv { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_estimation { get; set; }

        public int? id_estimation_other { get; set; }

        public double? m5 { get; set; }

        public bool? dopusk_izm { get; set; }

        [StringLength(50)]
        public string primech { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime p36 { get; set; }

        [StringLength(10)]
        public string estimation_other { get; set; }

        public double? m6 { get; set; }

        public double? m7 { get; set; }

        public double? m8 { get; set; }

        public double? m9 { get; set; }

        public double? m10 { get; set; }

        public double? m11 { get; set; }

        public double? m12 { get; set; }

        public int? id_ebe_var { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(30)]
        public string p31k { get; set; }
    }
}
