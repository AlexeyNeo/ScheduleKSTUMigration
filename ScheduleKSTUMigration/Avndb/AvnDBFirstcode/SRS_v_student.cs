namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SRS_v_student
    {
        [Key]
        [Column(Order = 0)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string p2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string p3 { get; set; }
    }
}
