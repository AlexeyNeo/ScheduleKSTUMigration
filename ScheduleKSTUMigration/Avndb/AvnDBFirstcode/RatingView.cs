namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RatingView")]
    public partial class RatingView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public string t_fio { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 4)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double p53 { get; set; }

        [StringLength(10)]
        public string p45 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p54 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Column("p25-2")]
        [StringLength(300)]
        public string p25_2 { get; set; }

        [Key]
        [Column("p23-2", Order = 11)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        public double? srs { get; set; }

        public double? rzr { get; set; }

        public double? ind_z { get; set; }

        public double? seminar { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_examination { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_sh { get; set; }
    }
}
