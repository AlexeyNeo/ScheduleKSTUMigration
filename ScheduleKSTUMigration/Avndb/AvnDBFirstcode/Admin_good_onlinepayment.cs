namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_good_onlinepayment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_onlinePaymentStream { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string account { get; set; }

        [Key]
        [Column("operator", Order = 3)]
        [StringLength(200)]
        public string _operator { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string txn_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime txn_date { get; set; }

        [Key]
        [Column(Order = 6)]
        public float sum { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string payerName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(14)]
        public string place { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool isCanceled { get; set; }

        public int? id_student { get; set; }

        public int? id_teacher { get; set; }

        public int? id_abiturient { get; set; }

        [StringLength(100)]
        public string additional { get; set; }

        public long? id_onlinePaymentPreparedAccount { get; set; }

        public bool? isOnlinePaymentStreamCanceled { get; set; }
    }
}
