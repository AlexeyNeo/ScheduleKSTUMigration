namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Elect_org
    {
        [Key]
        public int id_organ { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(30)]
        public string elected_as { get; set; }

        [StringLength(15)]
        public string year_elect { get; set; }

        [StringLength(15)]
        public string year_End { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(50)]
        public string organ { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
