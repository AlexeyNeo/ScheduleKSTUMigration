namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsActionLog
    {
        [Key]
        public long id_smsActionLog { get; set; }

        public long id_smsMessage { get; set; }

        public int id_user { get; set; }

        public int id_userType { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }
    }
}
