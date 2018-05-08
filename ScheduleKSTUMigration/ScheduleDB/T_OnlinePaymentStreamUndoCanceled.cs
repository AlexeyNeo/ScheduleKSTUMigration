namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentStreamUndoCanceled
    {
        [Key]
        public long id_onlinePaymentStreamUndoCanceled { get; set; }

        public long id_onlinePaymentStream { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(100)]
        public string _operator { get; set; }

        public DateTime uncanceled { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string request { get; set; }

        [Required]
        [StringLength(50)]
        public string fromAddress { get; set; }
    }
}
