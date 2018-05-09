namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentTransfer_Virtual
    {
        [Key]
        public int id_PaymentTransferVirtual { get; set; }

        public int id_payment { get; set; }

        public int? id_NewYear { get; set; }

        public int? id_newRate { get; set; }

        public int? id_newGroup { get; set; }

        public double? p102NewSpec { get; set; }

        public int? id_newSpecP102 { get; set; }

        public DateTime? ondate { get; set; }

        public int? id_v_opl { get; set; }
    }
}
