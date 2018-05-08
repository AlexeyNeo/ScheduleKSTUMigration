namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ee")]
    public partial class ee
    {
        [Key]
        public int id_ee { get; set; }

        public int id_estimation { get; set; }

        public int id_exmination { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual estimation estimation { get; set; }

        public virtual examination examination { get; set; }
    }
}
