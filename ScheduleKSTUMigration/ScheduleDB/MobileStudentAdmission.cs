namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileStudentAdmission")]
    public partial class MobileStudentAdmission
    {
        public int MobileStudentAdmissionID { get; set; }

        public int IDWS { get; set; }

        public int SendDay { get; set; }

        public int SendMonth { get; set; }

        public DateTime RecordTimeStamp { get; set; }
    }
}
