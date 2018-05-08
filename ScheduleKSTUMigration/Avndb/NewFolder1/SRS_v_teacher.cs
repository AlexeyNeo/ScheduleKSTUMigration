namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SRS_v_teacher
    {
        [Key]
        [Column(Order = 0)]
        public int id_teacher { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string p26 { get; set; }

        [StringLength(50)]
        public string p28 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string p27 { get; set; }
    }
}
