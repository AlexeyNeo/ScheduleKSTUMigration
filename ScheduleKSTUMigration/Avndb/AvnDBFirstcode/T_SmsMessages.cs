namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsMessages
    {
        [Key]
        public long id_smsMessage { get; set; }

        public int id_userFrom { get; set; }

        public int id_userFromType { get; set; }

        [Required]
        [StringLength(500)]
        public string message { get; set; }
    }
}
