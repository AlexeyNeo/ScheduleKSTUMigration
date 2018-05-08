namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_ank_c
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

        [Column("1")]
        public decimal? C1 { get; set; }

        [Column("2")]
        public decimal? C2 { get; set; }

        [Column("3")]
        public decimal? C3 { get; set; }

        [Column("4")]
        public decimal? C4 { get; set; }

        [Column("5")]
        public decimal? C5 { get; set; }

        [Column("6")]
        public decimal? C6 { get; set; }

        [Column("7")]
        public decimal? C7 { get; set; }

        [Column("8")]
        public decimal? C8 { get; set; }

        [Column("9")]
        public decimal? C9 { get; set; }

        [Column("10")]
        public decimal? C10 { get; set; }

        [Column("11")]
        public decimal? C11 { get; set; }

        [Column("12")]
        public decimal? C12 { get; set; }

        [Column("13")]
        public decimal? C13 { get; set; }

        [Column("14")]
        public decimal? C14 { get; set; }

        [Column("15")]
        public decimal? C15 { get; set; }

        [Column("16")]
        public decimal? C16 { get; set; }

        [Column("17")]
        public decimal? C17 { get; set; }

        [Column("18")]
        public decimal? C18 { get; set; }

        [Column("19")]
        public decimal? C19 { get; set; }

        [Column("20")]
        public decimal? C20 { get; set; }
    }
}
