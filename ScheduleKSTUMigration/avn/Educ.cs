namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Educ")]
    public partial class Educ
    {
        [Key]
        public int id_educ { get; set; }

        public int? id_edu { get; set; }

        public DateTime? Date_enter { get; set; }

        public DateTime? Date_End { get; set; }

        [StringLength(80)]
        public string Faculty { get; set; }

        public int? id_educ_t { get; set; }

        public int? id_quit_course { get; set; }

        public int? id_special { get; set; }

        public int id_teacher { get; set; }

        [StringLength(20)]
        public string Diploma_No { get; set; }

        [StringLength(100)]
        public string vuz { get; set; }

        public int? id_diploma_kval { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual Diploma_kval Diploma_kval { get; set; }

        public virtual Edu Edu { get; set; }

        public virtual Educ_t Educ_t { get; set; }

        public virtual Quit_Course Quit_Course { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
