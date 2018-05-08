namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RNK")]
    public partial class RNK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string p42 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }
    }
}
