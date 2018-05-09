namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentStream
    {
        [Key]
        public long id_onlinePaymentStream { get; set; }

        [Required]
        [StringLength(30)]
        public string account { get; set; }

        public int id_onlinePaymentAccountType { get; set; }

        public int id_bank { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(200)]
        public string _operator { get; set; }

        [Required]
        [StringLength(30)]
        public string txn_id { get; set; }

        public DateTime txn_date { get; set; }

        public float sum { get; set; }

        public int id_uslug { get; set; }

        public int id_user { get; set; }

        public short id_userType { get; set; }

        [Required]
        [StringLength(100)]
        public string payerName { get; set; }

        [Required]
        [StringLength(50)]
        public string fromAddress { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string request { get; set; }

        public bool isCanceled { get; set; }

        public bool isTest { get; set; }
    }
}
