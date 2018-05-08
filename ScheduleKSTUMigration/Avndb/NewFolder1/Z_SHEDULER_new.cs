namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_SHEDULER_new
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_shcedule { get; set; }

        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_discipline { get; set; }

        public int? kredit { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_nedeli { get; set; }

        public int? id_day { get; set; }

        public int? id_time { get; set; }

        public int? id_teacher { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_group { get; set; }

        public byte? rrnkType { get; set; }

        public int? id_teacherOwner { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? id_semester { get; set; }

        public int? id_faculty { get; set; }

        public int? id_speciality { get; set; }
    }
}
