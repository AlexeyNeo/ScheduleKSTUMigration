namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ed_sh_gr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(152)]
        public string p26 { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [StringLength(10)]
        public string p45 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 4)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double p53 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double p54 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }
    }
}
