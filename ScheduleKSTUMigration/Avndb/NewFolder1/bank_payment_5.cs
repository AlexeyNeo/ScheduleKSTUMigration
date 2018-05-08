namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_payment_5
    {
        [Key]
        [Column(Order = 0)]
        public DateTime p103 { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        public double sum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        [StringLength(200)]
        public string primech { get; set; }
    }
}
