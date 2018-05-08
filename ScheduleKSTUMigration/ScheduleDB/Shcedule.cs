namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shcedule")]
    public partial class Shcedule
    {
        [Key]
        public int id_shcedule { get; set; }

        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_faculty { get; set; }

        public int? id_speciality { get; set; }

        public int? kredit { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_nedeli { get; set; }

        public int? id_day { get; set; }

        public int? id_time { get; set; }

        public int? id_teacher { get; set; }

        public int? id_rrnk { get; set; }

        public byte? rrnkType { get; set; }

        public int? id_teacherOwner { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? udate { get; set; }

        public virtual discipline discipline { get; set; }

        public virtual Time_ Time_ { get; set; }
    }
}
