namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileStudentDolg")]
    public partial class MobileStudentDolg
    {
        public int MobileStudentDolgID { get; set; }

        public int StudentID { get; set; }

        public decimal DolgSum { get; set; }

        public DateTime RecordTimeStamp { get; set; }
    }
}
