namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ind_ved_3
    {
        [StringLength(53)]
        public string sh_st { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p54 { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 7)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double p53 { get; set; }

        [StringLength(10)]
        public string p45 { get; set; }

        public double? seminar { get; set; }

        [StringLength(50)]
        public string v_zanyatii { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_zanyatii { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_examination { get; set; }

        public int? sp_disc { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        public double? times { get; set; }

        [StringLength(10)]
        public string s_component { get; set; }
    }
}
