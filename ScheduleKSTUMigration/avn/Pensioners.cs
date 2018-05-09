namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pensioners
    {
        [Key]
        public int id_pensioner { get; set; }

        public int id_teacher { get; set; }

        public DateTime? date { get; set; }

        public int? id_district { get; set; }

        [Required]
        [StringLength(10)]
        public string AVN_user { get; set; }

        [Required]
        [StringLength(10)]
        public string AVN_update { get; set; }

        public bool pensioner { get; set; }
    }
}
