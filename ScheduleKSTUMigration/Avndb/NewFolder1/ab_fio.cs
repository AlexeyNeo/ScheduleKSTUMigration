namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ab_fio
    {
        [Key]
        [Column(Order = 0)]
        public int id_student { get; set; }

        [Key]
        [Column("ab_fio", Order = 1)]
        [StringLength(152)]
        public string ab_fio1 { get; set; }

        public bool? isStudent { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool del { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(10)]
        public string idid { get; set; }
    }
}
