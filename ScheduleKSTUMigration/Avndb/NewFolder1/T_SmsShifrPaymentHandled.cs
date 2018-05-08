namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsShifrPaymentHandled
    {
        [Key]
        public int id_smsShifrPaymentHandled { get; set; }

        public int year { get; set; }
    }
}
