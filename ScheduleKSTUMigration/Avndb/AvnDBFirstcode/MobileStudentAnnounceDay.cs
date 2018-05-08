namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileStudentAnnounceDay
    {
        [Key]
        public int MobileStudentAnnounceDaysID { get; set; }

        public int AnnounceType { get; set; }

        public DateTime StartDate { get; set; }
    }
}
