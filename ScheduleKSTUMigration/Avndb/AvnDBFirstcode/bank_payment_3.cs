namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_payment_3
    {
        [Key]
        [Column(Order = 0)]
        public DateTime p103 { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        public double sum { get; set; }

        public int? id_student { get; set; }

        public int? day { get; set; }
    }
}
