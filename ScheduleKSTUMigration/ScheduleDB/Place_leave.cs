namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Place_leave
    {
        [Key]
        public int id_place_leave { get; set; }

        public int? id_teacher { get; set; }

        public int? id_republic { get; set; }

        public int? id_ragionKR { get; set; }

        public int? id_districtKR { get; set; }

        public int? id_cityKR { get; set; }

        public int? id_villageKR { get; set; }

        [StringLength(40)]
        public string Address { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
