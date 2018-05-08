namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileToken")]
    public partial class MobileToken
    {
        public int MobileTokenID { get; set; }

        public int StudentID { get; set; }

        public string Token { get; set; }

        public DateTime RecordTimeStamp { get; set; }
    }
}
