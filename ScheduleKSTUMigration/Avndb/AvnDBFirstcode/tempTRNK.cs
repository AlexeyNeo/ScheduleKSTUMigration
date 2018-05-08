namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tempTRNK")]
    public partial class tempTRNK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [StringLength(20)]
        public string id_ua { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_country { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string s_p14_7 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Citizenship { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string Citizenship { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Nationality { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Nationality { get; set; }

        public int? kol_st { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_st_b { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_st_k { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_st_m { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_st_j { get; set; }
    }
}
