namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anketirovanie_RS
    {
        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        public int? st { get; set; }

        public int? st_sdali { get; set; }

        public int? kol_ank { get; set; }

        public decimal? b1 { get; set; }

        public decimal? b2 { get; set; }

        public decimal? B3 { get; set; }

        public decimal? B4 { get; set; }

        public decimal? B5 { get; set; }

        public decimal? B6 { get; set; }

        public decimal? B7 { get; set; }

        public decimal? B8 { get; set; }

        public decimal? B9 { get; set; }

        public decimal? B10 { get; set; }

        public decimal? B11 { get; set; }

        public decimal? B12 { get; set; }

        public decimal? B13 { get; set; }

        public int? YES { get; set; }

        public int? NO { get; set; }

        public int? KK1 { get; set; }

        public int? KK2 { get; set; }

        public int? KK3 { get; set; }

        public int? KK4 { get; set; }

        public int? KK5 { get; set; }

        public decimal? sum { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(24)]
        public string p42 { get; set; }
    }
}
