namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partiya")]
    public partial class Partiya
    {
        [Key]
        public int id_partia { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        public DateTime? date { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
