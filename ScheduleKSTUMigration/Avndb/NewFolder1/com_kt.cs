namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_kt
    {
        [Key]
        public int id_com_kafedra_teacher { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual kafedra kafedra { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
