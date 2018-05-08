namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_PaymentTransferVirtual
    {
        public int? id_student { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_PaymentTransferVirtual { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Year { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string rate { get; set; }

        [StringLength(56)]
        public string groups { get; set; }

        [StringLength(100)]
        public string orders { get; set; }

        [Key]
        [Column(Order = 3)]
        public double SummaFrom { get; set; }

        [StringLength(30)]
        public string Dates { get; set; }

        public double? SUMMA { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(475)]
        public string speciality { get; set; }

        [StringLength(40)]
        public string v_opl { get; set; }
    }
}
