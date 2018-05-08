namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment3V
    {
        public int? id_student { get; set; }

        [Key]
        [Column(Order = 0)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }

        [StringLength(20)]
        public string p104 { get; set; }

        [StringLength(40)]
        public string p105 { get; set; }

        [StringLength(10)]
        public string p32 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [StringLength(80)]
        public string uslugi { get; set; }

        public int? id_AVN_user { get; set; }
    }
}
