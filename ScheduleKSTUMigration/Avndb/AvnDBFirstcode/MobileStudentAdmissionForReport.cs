namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileStudentAdmissionForReport")]
    public partial class MobileStudentAdmissionForReport
    {
        public int MobileStudentAdmissionForReportID { get; set; }

        public int StudyYear { get; set; }

        public int IDWS { get; set; }

        [StringLength(250)]
        public string WSName { get; set; }

        public int GroupID { get; set; }

        public int StudentID { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime RecordTimeStamp { get; set; }
    }
}
