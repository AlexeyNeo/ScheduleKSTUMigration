namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_est
    {
        [Key]
        public int id_f_e { get; set; }

        [Required]
        [StringLength(40)]
        public string p109 { get; set; }

        public int? sessiya { get; set; }

        public int? sessiya_sv { get; set; }

        public int? avn13 { get; set; }

        public bool isPersonal { get; set; }
    }
}
