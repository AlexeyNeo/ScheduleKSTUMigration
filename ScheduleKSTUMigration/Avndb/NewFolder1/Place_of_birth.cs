namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Place_of_birth
    {
        [Key]
        public int id_place_of_birth { get; set; }

        public int? id_teacher { get; set; }

        public int? id_republic { get; set; }

        public int? id_regionKR { get; set; }

        public int? id_districtKR { get; set; }

        public int? id_cityKR { get; set; }

        public int? id_villageKR { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
