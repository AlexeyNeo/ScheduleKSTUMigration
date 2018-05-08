namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VillageKR")]
    public partial class VillageKR
    {
        [Key]
        public int IDVillage { get; set; }

        public int IDDistrict { get; set; }

        [Required]
        [StringLength(25)]
        public string NameVillage { get; set; }

        public short? IDAttribute { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? visible { get; set; }
    }
}
