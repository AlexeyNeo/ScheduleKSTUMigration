namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kvalifikation")]
    public partial class Kvalifikation
    {
        [Key]
        public int id_kvalification { get; set; }

        [Column("kvalifikation")]
        public int? kvalifikation1 { get; set; }

        [StringLength(50)]
        public string place { get; set; }

        public int? id_trudoem { get; set; }

        [StringLength(50)]
        public string sertifikate { get; set; }

        public int? id_teacher { get; set; }

        public DateTime? date_1 { get; set; }

        public DateTime? date_2 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(100)]
        public string theme { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
