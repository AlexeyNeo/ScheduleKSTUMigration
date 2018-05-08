namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_log2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string mm { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? kredits { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_table { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string table { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_field { get; set; }

        [Key]
        [Column(Order = 7)]
        public string name { get; set; }

        [StringLength(50)]
        public string detal { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_tableRow { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string oldValue { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string newValue { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime updated { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string userComp { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(200)]
        public string AVN_login { get; set; }
    }
}
