namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class a_year_1
    {
        [Key]
        public int id_a_year { get; set; }

        [Required]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? sh_year { get; set; }

        public int? u_god { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
