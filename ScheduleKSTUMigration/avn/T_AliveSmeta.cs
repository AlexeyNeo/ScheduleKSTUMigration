namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_AliveSmeta
    {
        [Key]
        public long id_aliveSmeta { get; set; }

        public int id_smeta { get; set; }

        public int id_speciality { get; set; }

        public int id_rate { get; set; }

        public int id_country { get; set; }

        public int id_a_year { get; set; }

        public double p106 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        [Required]
        [StringLength(128)]
        public string caller { get; set; }

        public int id_logAction { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(100)]
        public string host { get; set; }
    }
}
