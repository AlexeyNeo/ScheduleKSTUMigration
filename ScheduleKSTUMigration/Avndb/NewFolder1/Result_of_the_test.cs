namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Result_of_the_test
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        public int? id_student { get; set; }

        public int? ball { get; set; }

        public DateTime? GenerateDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public int? id_pole { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? attempt { get; set; }
    }
}
