namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileRaportDetail")]
    public partial class MobileRaportDetail
    {
        [Key]
        public int MobileAnnounceDetailID { get; set; }

        public int MobileAnnounceID { get; set; }

        public int StudentID { get; set; }

        public int CreateUserID { get; set; }

        public DateTime RecordTimeStamp { get; set; }

        public virtual MobileRaport MobileRaport { get; set; }
    }
}
