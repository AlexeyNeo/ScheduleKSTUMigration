namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_StudentJournalVisit
    {
        [Key]
        public long id_studentJournalVisit { get; set; }

        public int id_teacher { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int id_student { get; set; }

        public int id_studentGroup { get; set; }

        public int id_semesterOrWs { get; set; }

        public int id_groupOrPorok { get; set; }

        public bool isPotok { get; set; }

        public int id_discipline { get; set; }

        public int credits { get; set; }

        [Column(TypeName = "date")]
        public DateTime visitDate { get; set; }

        public bool isVisited { get; set; }

        public int id_vid_zaniatiy { get; set; }

        public byte timesCount { get; set; }

        public int id_time { get; set; }
    }
}
