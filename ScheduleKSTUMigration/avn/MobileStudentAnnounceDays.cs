namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileStudentAnnounceDays
    {
        public int MobileStudentAnnounceDaysID { get; set; }

        public int AnnounceType { get; set; }

        public DateTime StartDate { get; set; }
    }
}
