namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Antekirovanie_RS_kafedra
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
        [StringLength(24)]
        public string p42 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        public int? stud { get; set; }

        public int? sdal { get; set; }

        public int? anket { get; set; }

        public decimal? v1 { get; set; }

        public decimal? v2 { get; set; }

        public decimal? v3 { get; set; }

        public decimal? v4 { get; set; }

        public decimal? v5 { get; set; }

        public decimal? v6 { get; set; }

        public decimal? v7 { get; set; }

        public decimal? v8 { get; set; }

        public decimal? v9 { get; set; }

        public decimal? v10 { get; set; }

        public decimal? v11 { get; set; }

        public decimal? v12 { get; set; }

        public decimal? v13 { get; set; }

        public decimal? s_sum { get; set; }
    }
}
