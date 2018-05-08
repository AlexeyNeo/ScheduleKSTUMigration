namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_admin_online_payment_canceled_check
    {
        public int? id_student { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool isOnlinePaymentStreamCanceled { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool isCanceled { get; set; }
    }
}
