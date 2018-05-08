namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rasp_student_SH
    {
        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? kredit { get; set; }

        public int? id_faculty { get; set; }

        public int? id_speciality { get; set; }

        public int? b_num_nedeli { get; set; }

        public int? e_num_nedeli { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ch_zn { get; set; }

        public int? day_number { get; set; }

        [StringLength(10)]
        public string Day_name { get; set; }

        public int? id_time { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        public int? id_auditorium { get; set; }

        public int? sotr_time { get; set; }

        public int? id_teacher { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? id_rrnk { get; set; }

        public byte? rrnkType { get; set; }

        public int? kaf { get; set; }
    }
}
