namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitings
    {
        [Key]
        public int id_visitings { get; set; }

        public int? id_a_year { get; set; }

        public byte? monthID { get; set; }

        public byte? dayID { get; set; }

        public int? id_student { get; set; }

        public int? id_group { get; set; }

        public int? id_discipline { get; set; }

        public bool? was { get; set; }

        public DateTime? createDate { get; set; }

        public bool? hasSpravka { get; set; }

        [StringLength(50)]
        public string descr { get; set; }
    }
}
