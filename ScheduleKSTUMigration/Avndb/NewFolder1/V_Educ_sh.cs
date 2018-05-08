namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Educ_sh
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_sh { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(24)]
        public string p42 { get; set; }

        public short? ws_sort { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 7)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_examination { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        public int? Krdt { get; set; }

        [Key]
        [Column(Order = 12)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 13)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 14)]
        public double p53 { get; set; }

        public double? srs { get; set; }

        public double? rzr { get; set; }

        public double? ind_z { get; set; }

        public double? seminar { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p54 { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? x { get; set; }
    }
}
