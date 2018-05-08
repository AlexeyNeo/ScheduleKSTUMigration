namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BriefDisciplineInfo")]
    public partial class BriefDisciplineInfo
    {
        [Key]
        [Column(Order = 0)]
        public int id_discipline { get; set; }

        public string brief_p34 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }
    }
}
