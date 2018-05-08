namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_online_payment
    {
        public int id { get; set; }

        public double? sum { get; set; }

        public DateTime? date { get; set; }

        [StringLength(255)]
        public string descr { get; set; }

        [StringLength(255)]
        public string account { get; set; }

        [StringLength(255)]
        public string account2 { get; set; }

        public int? id_onlinePaymentPreparedAccount { get; set; }
    }
}
