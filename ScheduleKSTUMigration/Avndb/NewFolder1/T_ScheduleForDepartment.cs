namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ScheduleForDepartment
    {
        [Key]
        public int id_scheduleForDepartment { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int id_discipline { get; set; }

        public int kredit { get; set; }

        public int id_nedeli { get; set; }

        public int id_day { get; set; }

        public int id_time { get; set; }

        public int id_kafedra { get; set; }

        public int id_vid_zaniatiy { get; set; }

        public int id_group { get; set; }

        public int id_auditorium { get; set; }
    }
}
