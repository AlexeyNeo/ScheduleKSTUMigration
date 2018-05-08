namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_ank
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionnairesId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

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
        public int id_teacher { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        public int? kol_ank { get; set; }

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

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int yes { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int no { get; set; }

        [Column("1")]
        public int? C1 { get; set; }

        [Column("2")]
        public int? C2 { get; set; }

        [Column("3")]
        public int? C3 { get; set; }

        [Column("4")]
        public int? C4 { get; set; }

        [Column("5")]
        public int? C5 { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_dis { get; set; }
    }
}
