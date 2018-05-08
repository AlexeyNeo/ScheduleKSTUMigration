namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_AlivePaymentTransfer
    {
        [Key]
        public int id_alivePaymentTransfer { get; set; }

        public int? id_PaymentTransfer { get; set; }

        public int id_payment { get; set; }

        public int? id_NewYear { get; set; }

        public int? id_newRate { get; set; }

        public int? id_newGroup { get; set; }

        public double? p102NewSpec { get; set; }

        public int? id_newSpecP102 { get; set; }

        [Required]
        [StringLength(128)]
        public string caller { get; set; }

        public int id_logAction { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(100)]
        public string host { get; set; }
    }
}
