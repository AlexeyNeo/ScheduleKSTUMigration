namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("smeta")]
    public partial class smeta
    {
        [Key]
        public int id_smeta { get; set; }

        public int id_speciality { get; set; }

        public int id_rate { get; set; }

        public int id_country { get; set; }

        public int id_a_year { get; set; }

        public double p106 { get; set; }

        [StringLength(20)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual a_year a_year { get; set; }

        public virtual com_sfe com_sfe { get; set; }

        public virtual country country { get; set; }

        public virtual rate rate { get; set; }
    }
}
