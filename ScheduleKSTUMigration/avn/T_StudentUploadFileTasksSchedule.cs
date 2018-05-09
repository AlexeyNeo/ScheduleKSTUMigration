namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_StudentUploadFileTasksSchedule
    {
        [Key]
        public int id_studentUploadFileTasksSchedule { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int id_group { get; set; }

        public int id_discipline { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }
    }
}
