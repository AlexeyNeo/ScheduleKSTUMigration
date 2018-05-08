namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pensioner
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

        [Column("pensioner")]
        public bool pensioner1 { get; set; }
    }
}
