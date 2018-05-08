namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileStudentDuty")]
    public partial class MobileStudentDuty
    {
        public int MobileStudentDutyID { get; set; }

        public int StudentID { get; set; }

        public int DutyCount { get; set; }

        public DateTime RecordTimeStamp { get; set; }
    }
}
