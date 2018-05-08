namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V1
    {
        [Key]
        [Column(Order = 0)]
        public double Expr1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal id_onlinePaymentStream { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        public int? id_student { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime p103 { get; set; }
    }
}
