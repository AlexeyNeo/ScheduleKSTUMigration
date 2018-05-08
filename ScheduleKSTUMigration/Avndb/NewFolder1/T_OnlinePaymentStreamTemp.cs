namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentStreamTemp
    {
        [Key]
        public long id_onlinePaymentStreamTemp { get; set; }

        public long id_onlinePaymentStream { get; set; }

        public short id_onlinePaymentAction { get; set; }

        public bool isHandled { get; set; }
    }
}
