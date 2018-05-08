namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentCheckCommandLog
    {
        [Key]
        public long id_onlinePaymentCheckCommandLog { get; set; }

        [Required]
        [StringLength(50)]
        public string account { get; set; }

        [Required]
        [StringLength(32)]
        public string requestHash { get; set; }

        public DateTime lastDateCall { get; set; }

        public int numberOfCalls { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string request { get; set; }

        [Required]
        [StringLength(30)]
        public string fromAddress { get; set; }

        public byte type { get; set; }
    }
}
