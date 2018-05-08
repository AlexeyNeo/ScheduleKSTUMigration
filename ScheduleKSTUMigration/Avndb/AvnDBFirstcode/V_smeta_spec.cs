namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_smeta_spec
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string p108 { get; set; }

        public int? id_direction { get; set; }

        [Column("p24-1")]
        [StringLength(50)]
        public string p24_1 { get; set; }

        [Column("p24-2")]
        [StringLength(300)]
        public string p24_2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Column("p25-1")]
        [StringLength(20)]
        public string p25_1 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        public int? id_country { get; set; }

        [Column("p14-7")]
        [StringLength(100)]
        public string p14_7 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double KK1 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double KK2 { get; set; }

        [Key]
        [Column(Order = 7)]
        public double KK3 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double KK4 { get; set; }

        [Key]
        [Column(Order = 9)]
        public double KK5 { get; set; }

        [Key]
        [Column(Order = 10)]
        public double KK6 { get; set; }
    }
}
