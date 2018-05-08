namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kv_job
    {
        [Key]
        public int id_kv_job { get; set; }

        public int? id_student { get; set; }

        public int? id_estimation { get; set; }

        [Column(TypeName = "text")]
        public string p86 { get; set; }

        public DateTime? p87 { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual estimation estimation { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
