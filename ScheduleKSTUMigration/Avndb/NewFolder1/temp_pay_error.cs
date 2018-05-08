namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_pay_error
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_payment { get; set; }

        public int? id_rate { get; set; }

        public int? id_speciality { get; set; }

        public int? id_student { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [StringLength(100)]
        public string p104_1 { get; set; }
    }
}
