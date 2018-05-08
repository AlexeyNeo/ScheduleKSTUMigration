namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentForAbit")]
    public partial class PaymentForAbit
    {
        public int? id_abiturient { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(80)]
        public string uslugi { get; set; }

        [Key]
        [Column(Order = 1)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-2", Order = 4)]
        [StringLength(100)]
        public string p23_2 { get; set; }
    }
}
