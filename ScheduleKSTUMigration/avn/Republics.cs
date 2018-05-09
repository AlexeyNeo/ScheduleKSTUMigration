namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Republics
    {
        [Key]
        public int id_republics { get; set; }

        [StringLength(50)]
        public string republic { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? visible { get; set; }

        [StringLength(50)]
        public string RS { get; set; }
    }
}
