namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudyCemester")]
    public partial class StudyCemester
    {
        public int StudyCemesterID { get; set; }

        public int CemesterNumber { get; set; }

        public int StartMonth { get; set; }

        public int StartDay { get; set; }
    }
}
