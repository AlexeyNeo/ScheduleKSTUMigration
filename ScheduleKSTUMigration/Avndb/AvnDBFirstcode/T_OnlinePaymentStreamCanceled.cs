namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentStreamCanceled
    {
        [Key]
        public long id_onlinePaymentStreamCanceled { get; set; }

        public long id_onlinePaymentStream { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(100)]
        public string _operator { get; set; }

        public DateTime canceled { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string request { get; set; }

        [Required]
        [StringLength(50)]
        public string fromAddress { get; set; }
    }
}
