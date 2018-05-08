namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usluga_rashod
    {
        [Key]
        public int id_usluga_rashod { get; set; }

        [StringLength(20)]
        public string shet { get; set; }

        [Required]
        [StringLength(50)]
        public string n_rashod { get; set; }

        public float? procent { get; set; }

        [Required]
        [StringLength(50)]
        public string oper { get; set; }

        public DateTime u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
