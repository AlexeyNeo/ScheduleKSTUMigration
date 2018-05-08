namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_net_nagr_reg_O
    {
        [StringLength(50)]
        public string sn_f1 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }
    }
}
