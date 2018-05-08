namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_prob
    {
        [StringLength(50)]
        public string republic { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string NameRegion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string NameDistrict { get; set; }
    }
}
