namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistrictKR")]
    public partial class DistrictKR
    {
        [Key]
        public int IDDistrict { get; set; }

        public int IDRegion { get; set; }

        [Required]
        [StringLength(25)]
        public string NameDistrict { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? visible { get; set; }
    }
}
