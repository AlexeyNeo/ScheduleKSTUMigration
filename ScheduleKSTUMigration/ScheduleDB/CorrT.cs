namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorrT")]
    public partial class CorrT
    {
        [Key]
        public int id_Corr_user { get; set; }

        [StringLength(20)]
        public string User { get; set; }

        [StringLength(20)]
        public string Pass { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
