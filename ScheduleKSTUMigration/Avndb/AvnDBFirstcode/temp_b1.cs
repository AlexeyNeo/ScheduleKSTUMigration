namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_b1
    {
        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_faculty { get; set; }

        public int? id_speciality { get; set; }

        public int? kredit { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_day { get; set; }

        public int? b_nedeli { get; set; }

        public int? e_nedeli { get; set; }

        public int? id_time { get; set; }

        public int? sort { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        public int? id_group { get; set; }

        public byte? rrnkType { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [StringLength(10)]
        public string Day_name { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        [Key]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }
    }
}
