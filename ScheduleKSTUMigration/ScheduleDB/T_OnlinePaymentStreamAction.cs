namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentStreamAction
    {
        [Key]
        public short id_onlinePaymentAction { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
