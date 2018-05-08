namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncorrT")]
    public partial class IncorrT
    {
        [Key]
        public int id_incorr { get; set; }

        [StringLength(20)]
        public string User { get; set; }

        [StringLength(20)]
        public string Pass { get; set; }

        public byte? id_corr_user { get; set; }

        public int? id_teacher { get; set; }

        public DateTime? Beg_date { get; set; }

        public DateTime? End_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
