namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V2
    {
        [Key]
        [Column(Order = 0)]
        public float Expr1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public long id_onlinePaymentStream { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }
    }
}
